﻿using System.Reflection;
using ShapeCrawler;

var pres = new Presentation();
var shapes = pres.Slides[0].Shapes;

var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
var sourceFileName = assemblyName + ".Microsoft_Edge_logo_(2019).svg";
var fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(sourceFileName)!;
shapes.AddPicture(fileStream);

shapes.AddPicture(fileStream);
var picture = shapes.GetByName<IPicture>("Picture 2");
picture.X += 150;
picture.Width = 96;
picture.Height = 96;

shapes.AddPicture(fileStream);
picture = shapes.GetByName<IPicture>("Picture 3");
picture.X += 300;
picture.Width = 96;
picture.Height = 96;

shapes.AddPicture(fileStream);
picture = shapes.GetByName<IPicture>("Picture 4");
picture.X += 450;
picture.Width = 96;
picture.Height = 96;

shapes.AddPicture(fileStream);
picture = shapes.GetByName<IPicture>("Picture 5");
picture.X += 600;
picture.Width = 96;
picture.Height = 96;

var filename = $"out/{assemblyName}.pptx";
Directory.CreateDirectory(Path.GetDirectoryName(filename)!);
File.Delete(filename);
pres.SaveAs(filename);
