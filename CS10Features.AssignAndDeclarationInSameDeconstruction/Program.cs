using CS10Features.AssignAndDeclarationInSameDeconstruction;

var rectangle = new Rectangle(200,300);

(int h, int w) = rectangle;

/// <summary>
/// Before C#10
/// </summary>
///

int height = 0;
int width = 0;

(height, width) = rectangle;


/// <summary>
/// Mix declaration and assignment
/// </summary>
///

int heightNew = 0;

(heightNew, int widthNew) = rectangle;