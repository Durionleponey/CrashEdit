using AltUI.Forms;
using CrashEdit.CE;
using CrashEdit.CE.Forms;
using CrashEdit.Crash;
using OpenTK.Graphics.OpenGL;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Media.Media3D;

namespace CrashEdit.CE
{
    [OrphanLegacyController(typeof(ZoneEntry))]
    public sealed class ZoneEntryController : EntryController
    {
        public ZoneEntryController(ZoneEntry zoneentry, SubcontrollerGroup parentGroup) : base(zoneentry, parentGroup)
        {
            ZoneEntry = zoneentry;
            AddMenuSeparator();
            AddMenu(CrashUI.Properties.Resources.ZoneEntryController_AcAddEntity, "Add", Menu_AddEntity);
            AddMenu(CrashUI.Properties.Resources.ZoneEntryController_AcChangeCollisionType, "Wrench", Menu_ChangeCollisionType);

            if (GameVersion == GameVersion.Crash2 && ZoneEntry.Entities.Count !=0) {
                AddMenu(CrashUI.Properties.Resources.ZoneEntryController_AcChangeEnvironmentType, "Wrench", Menu_ChangeEnvironmentType);

            }

        }

        public override bool EditorAvailable => true;

        public override Control CreateEditor()
        {
            return new ZoneEntryViewer(GetNSF(), Entry.EID);
        }

        public ZoneEntry ZoneEntry { get; }

        void Menu_AddEntity()
        {
            short id = 10;
            while (true)
            {
                foreach (ZoneEntry zone in GetEntries<ZoneEntry>())
                {
                    foreach (Entity otherentity in zone.Entities)
                    {
                        if (otherentity.ID == id)
                        {
                            goto FOUND_ID;
                        }
                    }
                }
                break;
            FOUND_ID:
                ++id;
                continue;
            }
            Entity newentity = Entity.Load(new Entity(new Dictionary<short, EntityProperty>()).Save());
            newentity.ID = id;
            ZoneEntry.Entities.Add(newentity);
            ++ZoneEntry.EntityCount;
        }

        void Menu_ChangeCollisionType()
        {
            try
            {
                byte[] searchPattern = null!;
                byte[] replacementPattern = null!;
                using (InputWindow inputWindows = new InputWindow(CrashUI.Properties.Resources.ZoneEntryController_AcChangeCollisionType, "Wrench",
                    "Enter collision type to replace (as a literal):", string.Empty, 4,
                    "Enter new collision type (as a literal):", string.Empty, 4))
                {
                    if (inputWindows.ShowDialog() == DialogResult.OK)
                    {
                        string input = inputWindows.Input;
                        string input2 = inputWindows.Input2;
                        if (input.Length != 4 || input2.Length != 4)
                        {
                            throw new ArgumentException("The input must be specified as a 4-digit hexadecimal number.");
                        }

                        searchPattern = BitConverter.GetBytes(Convert.ToUInt16(input, 16));
                        replacementPattern = BitConverter.GetBytes(Convert.ToUInt16(input2, 16));

                    }
                    else return;
                }

                byte[] layout = ZoneEntry.Layout;


                for (int i = 0x24; i <= layout.Length - searchPattern.Length; i += 2)
                {

                    bool isMatch = true;

                    for (int j = 0; j < searchPattern.Length; j++)
                    {
                        if (layout[i + j] != searchPattern[j])
                        {
                            isMatch = false;
                            break;
                        }
                    }
                    if (isMatch)
                    {
                        for (int j = 0; j < replacementPattern.Length; j++)
                        {
                            layout[i + j] = replacementPattern[j];
                        }
                    }
                }

                ZoneEntry.Layout = layout;
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Error: {ex.Message}", CrashUI.Properties.Resources.ZoneEntryController_AcChangeCollisionType);
                return;
            }
        }



        void Menu_ChangeEnvironmentType()//PROTO
        {
            try
            {

                int numberOfCamera = ZoneEntry.Zoneheader.CameraCount;

                int targetCamera = 1;

                if (numberOfCamera % 3 != 0) {
                    DarkMessageBox.ShowError($"Error Camera shoud be in group of 3", CrashUI.Properties.Resources.ZoneEntryController_AcChangeCollisionType);
                    return;
                }

                if (numberOfCamera > 3)
                {

                    int maxIndexCam = (numberOfCamera / 3) - 1;

                using (InputWindow inputWindow = new InputWindow($"Multiple Camera Detected In {ZoneEntry.Title}", "Select Camera Number", $"Please Put Cam Number: [0-{maxIndexCam}]", string.Empty, 1))
                    {

                        if (inputWindow.ShowDialog() == DialogResult.OK)
                        {
                            if (inputWindow.Input.Length == 0)
                            {
                                DarkMessageBox.ShowError("Please input camera number", "Error empty");
                                return;
                            }


                            if (Regex.IsMatch(inputWindow.Input, @"^\d$"))
                            {

                                int Intinput = int.Parse(inputWindow.Input);
                                if (0 <= Intinput && Intinput <= maxIndexCam)
                                {


                                    targetCamera = 1 + (Intinput * 3);

                                }
                                else {

                                    DarkMessageBox.ShowError("Out of index please input camera number", "Error bad input");
                                    return;



                                }


                            }
                            else {

                                DarkMessageBox.ShowError("Please input camera number", "Error bad input");
                                return;


                            }


                        }
                        else {
                            return;
                        }
                    }
                }


                Entity camera2 = ZoneEntry.Entities[targetCamera];


                using (EnvironmentEditor inputWindows = new EnvironmentEditor())
                {

                    

                    short FogDistanceID = 0x1DE;
                    short particules1ID = 0x1B5;
                    short particules2ID = 0x1B6;

                    if (inputWindows.ShowDialog() == DialogResult.OK)//PROTO
                    {

                        uint flagPropFog = 0x00000000;


                        if (inputWindows.UseFog)
                        {
                            flagPropFog = 0x00200000;


                            var propFogDistance = new EntityUInt32Property();
                            propFogDistance.Rows.Add(new EntityPropertyRow<uint>());
                            propFogDistance.Rows[0].MetaValue = 0;

                            propFogDistance = addValueToProp([0, 1], 0, propFogDistance);

                            byte resultFogDistance = (byte)inputWindows.FogValue;
                            uint fogValueEx = 0x00000040u | ((uint)resultFogDistance << 8);
                            propFogDistance.Rows[0].Values.Add(fogValueEx);

                            camera2.FogDistance = propFogDistance;
                            camera2.KnownProperties[FogDistanceID] = propFogDistance;

                        }


                            if (inputWindows.UseRecolor) {


                                short bgColorID = 0x1FA;

                                var bgColorProp = new EntityUInt32Property();

                                bgColorProp.Rows.Add(new EntityPropertyRow<uint>());
                                bgColorProp.Rows[0].MetaValue = 0;
                                bgColorProp.Rows[0].Values.Add(0x00000001);


                                bgColorProp.Rows[0].Values.Add(inputWindows.BackgroundTextureGapColor);


                                bgColorProp.Rows[0].Values.Add(0);

                                camera2.Backgrounds = bgColorProp;
                                camera2.KnownProperties[bgColorID] = bgColorProp;


                            }




                        
                        else
                        {

                            camera2.FogDistance = null;

                            camera2.KnownProperties.Remove(FogDistanceID);



                        }




                        if (!inputWindows.ParticleEffecIsActive)
                        {

                            camera2.Particles1 = null;

                            camera2.KnownProperties.Remove(particules1ID);

                            camera2.Particles2 = null;

                            camera2.KnownProperties.Remove(particules2ID);


                        }
                        else 
                        {

                            flagPropFog = flagPropFog | 0x00000010;//change bit nedded for particle


                            var particules1Prop = new EntityVictimProperty();

                            particules1Prop.Rows.Add(new EntityPropertyRow<EntityVictim>());
                            particules1Prop.Rows[0].MetaValue = 0;



                            particules1Prop.Rows[0].Values.Add(new EntityVictim((short)inputWindows.VelocityParticleValue[0]));
                            particules1Prop.Rows[0].Values.Add(new EntityVictim((short)inputWindows.VelocityParticleValue[1]));
                            particules1Prop.Rows[0].Values.Add(new EntityVictim((short)inputWindows.VelocityParticleValue[2]));


                            particules1Prop.Rows[0].Values.Add(new EntityVictim((short)inputWindows.ParticleAmountValue));

                            particules1Prop.Rows[0].Values.Add(new EntityVictim(0x0));
                            particules1Prop.Rows[0].Values.Add(new EntityVictim(0x770));



                            camera2.Particles1 = particules1Prop;
                            camera2.KnownProperties[particules1ID] = particules1Prop;



                            var particules2Prop = new EntityUInt32Property();


                            particules2Prop.Rows.Add(new EntityPropertyRow<uint>());
                            particules2Prop.Rows[0].MetaValue = 0;
                            particules2Prop.Rows[0].Values.Add(inputWindows.UpperParticleColor);

                            uint lowerParticleLower = inputWindows.LowerParticleColor;

                            if (inputWindows.UseParticleOneColor) { lowerParticleLower = inputWindows.UpperParticleColor; }
                            particules2Prop.Rows[0].Values.Add(lowerParticleLower);

                            
                            particules2Prop.Rows[0].Values.Add(0xE1000A00 | (uint)(inputWindows.ParticleVisibilityValue));

                            camera2.Particles2 = particules2Prop;
                            camera2.KnownProperties[particules2ID] = particules2Prop;



                        }



                        short flagsID = 0x185;
                        var flagsProp = new EntityUInt32Property();

                        flagsProp.Rows.Add(new EntityPropertyRow<uint>());
                        flagsProp.Rows[0].MetaValue = 0;
                        flagsProp.Rows[0].Values.Add(flagPropFog);

                        camera2.Flags = flagsProp;
                        camera2.KnownProperties[flagsID] = flagsProp;

                            

                    }



                }

                return;




            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Error: {ex.Message}", "");
            }
        }


        static EntityUInt32Property addValueToProp(uint[] values, int Rows, EntityUInt32Property prop)
        {

            for (int i = 0; i < values.Length; i++) {

                prop.Rows[Rows].Values.Add(values[i]);

            }
            return prop;
        }
    }
}



