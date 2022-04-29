# crud-angular-netcore

This project how to show a set of products from net core 3.1

Sorting grid form server side

I send 2 parameters:
-column
-direction

those parameters will be received by an endpoint and iperform and Dynamic Query by using Linq.

[HttpPost]
[Route("[action]")]
public ActionResult Sort(SortObject sortObject)
{
    List<Product> products = getRecordsFromFile();
    products = products.AsQueryable().OrderBy($"{sortObject.active} {sortObject.direction}").ToList();      
    return Ok(products);
}

Solution to this requirement : https://github.com/riupko/tech-task

Look and Feel: Material Design
FrontEnd: Angular
Backend: NetCore 3.1

![products](https://user-images.githubusercontent.com/18402098/166009489-da79dfe0-60c5-47cf-84bd-474b7970dbd3.gif)

Folder

tech-task-api: net core project
tech-task-crud: angular project



