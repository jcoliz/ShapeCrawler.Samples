//using DocumentFormat.OpenXml.Presentation;

using ShapeCrawler;

var pres = new Presentation("picture-adding.pptx");
using var image = new FileStream("picture.png", FileMode.Open, FileAccess.Read);

pres.Slides[0].Shapes.AddPicture(image);

pres.SaveAs("picture-added.pptx");