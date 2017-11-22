
function StoringObjects(input) {
let dict = [];
    for (var i = 0; i < input.length; i++) {
        let line = input[i];
        let splitInput = line.split(" -> ");
        dict.push({Name: splitInput[0], Age: splitInput[1], Grade: splitInput[2]})
    }

    for (let obj of dict) {
        console.log("Name: " + obj.Name)
        console.log("Age: " + obj.Age)
        console.log("Grade: " + obj.Grade)
    }
}


StoringObjects([
"Pesho -> 13 -> 6.00",
"Ivan -> 12 -> 5.57",
"Toni -> 13 -> 4.90"
])