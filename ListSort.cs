# list of numbers out of order with duplicates

var mylist = new list(1,8,8,2,10,100);
var orderedList = new list();

foreach (var item in mylist)
{
    var duplicate=false;
    foreach (var existing in orderedList)
    {
        if (item == existing)
        {
            duplicate=true;
        }
    }
    if (!duplicate)
    {
        orderedList.add(item);
    }
}