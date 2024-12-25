using System.Reflection;
using ShapeCrawler;

var assemblyName = Assembly.GetExecutingAssembly().GetName().Name!.Replace('-', '_');
var pptxFileName = assemblyName + ".picture-adding.pptx";
var pptxStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(pptxFileName)!;
var pres = new Presentation(pptxStream);

var imageFileName = assemblyName + ".picture.png";
var imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(imageFileName)!;

pres.Slides[0].Shapes.AddPicture(imageStream);

var filename = $"out/{assemblyName}.pptx";
Directory.CreateDirectory(Path.GetDirectoryName(filename)!);
File.Delete(filename);
pres.SaveAs(filename);
