using ShapeCrawler;

var pres = new Presentation();
var shapes = pres.Slides[0].Shapes;

using var stream = File.OpenRead("2x2.svg");
shapes.AddPicture(stream);
var pic = shapes[^1];
pic.GeometryType = Geometry.TopCornersRoundedRectangle;
pic.CornerSize = 25;

pres.SaveAs("out/Picture.SetGeometry.pptx");
