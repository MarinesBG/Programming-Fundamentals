function CapitalCaseWords(input) {
    let output = [];
    for (var i = 0; i < input.length; i++) {
        let splitInput = input[i].split(/\W+/);
        for (var j = 0; j < splitInput.length; j++) {
            if(splitInput[j] === splitInput[j].toUpperCase() && splitInput[j] != ''){
                output.push(splitInput[j])
            }
        }
    }
    console.log(output.join(", "))
}

CapitalCaseWords([
    "We start by HTML, CSS, JavaScript, JSON and REST.",
    "Later we touch some PHP, MySQL and SQL.",
    "Later we play with C#, EF, SQL Server and ASP.NET MVC.",
    "Finally, we touch some Java, Hibernate and Spring.MVC."
]);

