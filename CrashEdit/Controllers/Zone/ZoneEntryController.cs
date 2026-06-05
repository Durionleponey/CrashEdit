using AltUI.Forms;
using CrashEdit.CE;
using CrashEdit.CE.Forms;
using CrashEdit.Crash;
using OpenTK.Graphics.OpenGL;
using System.Web;

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
            AddMenu(CrashUI.Properties.Resources.ZoneEntryController_AcChangeEnvironmentType, "Wrench", Menu_ChangeEnvironmentType);


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
                Console.WriteLine($"searchPattern init ---> {searchPattern}");
                Console.WriteLine($"replacementPattern init ---> {replacementPattern}");
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

                        Console.WriteLine($"searchPattern converted ---> {BitConverter.ToString(searchPattern)}");
                        Console.WriteLine($"searchPattern.length---> {searchPattern.Length}");

                        Console.WriteLine($"replacementPattern converted ---> {BitConverter.ToString(replacementPattern)}");
                    }
                    else return;
                }

                byte[] layout = ZoneEntry.Layout;

                Console.WriteLine($"zone ENtry.layout ---> {BitConverter.ToString(ZoneEntry.Layout)}");

                Console.WriteLine($"zone ENtry ---> {ZoneEntry}");
                for (int i = 0x24; i <= layout.Length - searchPattern.Length; i += 2)
                {
                    //Console.WriteLine($"i-->{i}");
                    //Console.WriteLine($"layout[i] --> {layout[i]:X2}");

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



        void Menu_ChangeEnvironmentType()
        {
            try
            {
                //for (int i = 0; i < ZoneEntry.Entities.Count; i++)
                //{
                //    Entity entity = ZoneEntry.Entities[i];
                //    Console.WriteLine($"[{i}] ID={entity.ID}");
                //}


                //foreach (var key in camera2.KnownProperties)
                //{
                //    Console.WriteLine($"------>>>>{key}");

                //}
                //Console.WriteLine($"------>>>>{camera2.PropertyFields[478].Name}");//fogdistance
                //Console.WriteLine($"------>>>>{camera2.PropertyFields[478].Attributes}");//Private ??
                //Console.WriteLine($"------>>>>{camera2.PropertyFields[478].FieldType}");//------>>>>CrashEdit.Crash.EntityUInt32Property

                //var pomme = (EntityUInt32Property)camera2.KnownProperties[478];
                //foreach (var row in pomme.Rows)
                //{
                //    Console.WriteLine($"--->{row.Values}");
                //    foreach (var value in row.Values) {
                //        Console.WriteLine($"-value --->-> {value}");
                //    }
                //    }

                //Console.WriteLine($"------>>>>{camera2.PropertyFields[478].FieldType}");//------>>>>CrashEdit.Crash.EntityUInt32Property




                //EntityUInt32Property = pommeDeTerre.KnownProperties[];

                Entity camera2 = ZoneEntry.Entities[1];





                using (EnvironmentEditor inputWindows = new EnvironmentEditor(camera2.Flags))
                {
                    if (inputWindows.ShowDialog() == DialogResult.OK) 
                    {


                        short FogDistanceID = 0x1DE;

                        var fogProp = new EntityUInt32Property();
                        fogProp.Rows.Add(new EntityPropertyRow<uint>());
                        fogProp.Rows[0].MetaValue = 0;
                        fogProp.Rows[0].Values.Add(0);
                        fogProp.Rows[0].Values.Add(1);


                        byte result = (byte)inputWindows.FogValue;
                        uint fogValueEx = (0x00000F40u & ~0x0000FF00u) | ((uint)result << 8);
                        Console.WriteLine($"0x{fogValueEx:X8}");
                        fogProp.Rows[0].Values.Add(fogValueEx);

                        camera2.FogDistance = fogProp;
                        camera2.KnownProperties[FogDistanceID] = fogProp;



                        short flagsID = 0x185;
                        var flagsProp = new EntityUInt32Property();

                        flagsProp.Rows.Add(new EntityPropertyRow<uint>());
                        flagsProp.Rows[0].MetaValue = 0;
                        flagsProp.Rows[0].Values.Add(0x00200090);

                        camera2.Flags = flagsProp;
                        camera2.KnownProperties[flagsID] = flagsProp;



                        short bgColorID = 0x1FA;

                        var bgColorProp = new EntityUInt32Property();

                        bgColorProp.Rows.Add(new EntityPropertyRow<uint>());
                        bgColorProp.Rows[0].MetaValue = 0;
                        bgColorProp.Rows[0].Values.Add(0x00000001);
                        bgColorProp.Rows[0].Values.Add(0);
                        bgColorProp.Rows[0].Values.Add(0);

                        camera2.Backgrounds = bgColorProp;
                        camera2.KnownProperties[bgColorID] = bgColorProp;



                        Console.WriteLine(result);



                        Console.WriteLine($"UseFog={inputWindows.UseFog}, UseRain={inputWindows.UseRain}, FogValue={inputWindows.FogValue}");



                    }



                }

                return;
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Error: {ex.Message}", CrashUI.Properties.Resources.ZoneEntryController_AcChangeCollisionType);
            }
        }
    }
}



