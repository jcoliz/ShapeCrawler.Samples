using System.Reflection;
using ShapeCrawler;

var pres = new Presentation();
var shapes = pres.Slides[0].Shapes;

var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
var sourceFileName = assemblyName + ".2x2.svg";
var fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(sourceFileName)!;

shapes.AddPicture(fileStream);
var pic = shapes[^1];
pic.GeometryType = Geometry.TopCornersRoundedRectangle;
pic.CornerSize = 25;

var filename = $"out/{assemblyName}.pptx";
Directory.CreateDirectory(Path.GetDirectoryName(filename)!);
File.Delete(filename);
pres.SaveAs(filename);
