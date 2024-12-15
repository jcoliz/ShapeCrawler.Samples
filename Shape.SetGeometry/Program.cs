using ShapeCrawler;

var pres = new Presentation();
var shapes = pres.Slides[0].Shapes;

shapes.AddRectangle(48, 96, 96*2, 96);
var shape = shapes[^1];
shape.GeometryType = Geometry.RoundRectangle;
shape.CornerSize = 0.5m;

shapes.AddRectangle(48, 96*3, 96*2, 96*4);
shape = shapes[^1];
shape.GeometryType = Geometry.Round2SameRectangle;
shape.CornerSize = 0.25m;

shapes.AddRectangle(96*2, 96, 96, 96);
shape = shapes[^1];
shape.GeometryType = Geometry.Star5;

shapes.AddRectangle(96*3, 96, 96, 96);
shape = shapes[^1];
shape.GeometryType = Geometry.Ellipse;

pres.SaveAs("out/Shape.SetGeometry.pptx");
