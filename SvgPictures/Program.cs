using ShapeCrawler;
using Svg;

var pres = new Presentation();

var shapes = pres.Slides[0].Shapes;

var svg = SvgDocument.Open("cocktail-svgrepo-com.svg");

var renderer = SvgRenderer.FromNull();
var w = svg.Width.ToDeviceValue(renderer, UnitRenderingType.Horizontal, svg);
var h = svg.Height.ToDeviceValue(renderer, UnitRenderingType.Vertical, svg);
Console.WriteLine("{0} {1}", w, h);

shapes.AddPictureSvg(svg,96,96);
shapes.AddPictureSvg(svg,48,48);
var picture = shapes.GetByName<IPicture>("Picture 2");
picture.X += 150;
picture.Width = 96;
picture.Height = 96;

shapes.AddPictureSvg(svg,24,24);
picture = shapes.GetByName<IPicture>("Picture 3");
picture.X += 300;
picture.Width = 96;
picture.Height = 96;

shapes.AddPictureSvg(svg,12,12);
picture = shapes.GetByName<IPicture>("Picture 4");
picture.X += 450;
picture.Width = 96;
picture.Height = 96;

shapes.AddPictureSvg(svg,6,6);
picture = shapes.GetByName<IPicture>("Picture 5");
picture.X += 600;
picture.Width = 96;
picture.Height = 96;

pres.SaveAs("out/svg-array.pptx");
