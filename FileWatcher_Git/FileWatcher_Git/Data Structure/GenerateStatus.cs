using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Data;

namespace FileWatcher_Git.Data_Structure
{
    class GenerateStatus
    {
        List<DDirectory> directorylist;
        List<string> filelist;
        DataTable statustable;
        List<string> statusfiles;

        public GenerateStatus()
        {
            directorylist = new List<DDirectory>();
            statusfiles = new List<string>();

            statustable = new DataTable();
            statustable.Columns.Add("Files", Type.GetType("System.String"));
            statustable.Columns.Add("Status", Type.GetType("System.String"));

            XElement xe = XElement.Load(@"..\..\Lookup.xml");
            if (xe != null)
            {
                IEnumerable<XElement> directories = xe.Descendants("directory");
                foreach (XElement d in directories)
                {
                    DDirectory newdir = new DDirectory(d.Attribute("name").Value);
                    filelist = new List<string>();

                    IEnumerable<XElement> files = d.Descendants("filename");
                    foreach (XElement f in files)
                    {
                        filelist.Add(f.Value);
                        statusfiles.Add(newdir.dir + "\\" + f.Value);
                    }

                    newdir.file = filelist;
                    directorylist.Add(newdir);

                }
            }
        }

        public DataTable status(DateTime dtp)
        {
            if (dtp.DayOfWeek.ToString() == "Monday")
            {
                for (int i = 2; i > -1; i--)
                {
                    DateTime dp = dtp.AddDays(-i);

                   
                    foreach (string path in statusfiles)
                    {
                        string[] p = path.Split('|');

                        switch (p[1])
                        {
                            case "ASOFDATE":
                                p[1] = dp.ToString(p[2]);
                                break;

                            case "PREVIOUSDATE":
                                p[1] = dp.AddDays(-1).ToString(p[2]);
                                break;

                        }


                        string newpath = p[0] + p[1] + p[3];
                        Console.WriteLine("New Path : " + newpath);
                        statustable.Rows.Add();
                        statustable.Rows[statustable.Rows.Count - 1]["Files"] = newpath;

                        if (File.Exists(newpath))
                        {
                            foreach (DataRow dd in statustable.Rows)
                            {
                                if (dd["Files"].ToString() == newpath)
                                {
                                   dd["Status"] = "Found";
                                    
                                }

                            }
                        }

                    }

                }

                var r = statustable.Select("Status is null");

                foreach(DataRow ddd in r)
                {
                   ddd.Delete();
                   
                }
            }

            else
            {
                foreach (string path in statusfiles)
                {
                    string[] p = path.Split('|');

                    switch (p[1])
                    {
                        case "ASOFDATE":
                            p[1] = dtp.ToString(p[2]);
                            break;

                        case "PREVIOUSDATE":
                            p[1] = dtp.AddDays(-1).ToString(p[2]);
                            break;

                    }


                    string newpath = p[0] + p[1] + p[3];

                    statustable.Rows.Add();
                    statustable.Rows[statustable.Rows.Count - 1]["Files"] = newpath;

                    if (File.Exists(newpath))
                    {
                        foreach (DataRow dd in statustable.Rows)
                        {
                            if (dd["Files"].ToString() == newpath)
                            {
                                dd["Status"] = "Found";

                            }

                        }
                    }

                    else
                    {
                        foreach (DataRow dd in statustable.Rows)
                        {
                            if (dd["Files"].ToString() == newpath)
                            {
                                dd["Status"] = "Not Found";

                            }
                        }
                    }
                }
            }
            return statustable;
        }
    }
}
