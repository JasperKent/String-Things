if (true)
{
    int x = 666;

    var html = $"""""
                <!DOCTYPE html>
                <html lang="en" xmlns="http://www.w3.org/1999/xhtml">
                    <head>
                        <meta charset=\"utf-8\" />
                        <title>My Page</title>
                    </head>
                    <body>
                        <h1>This is a heart symbol: "\u2665"</h1>
                        <p>In C# 11 we can use """"</p>
                        <p>The value is {x}</p>
                    </body>
                </html>
                """"";

    using var writer = new StreamWriter("output.html", false);

    writer.WriteLine(html);
}