function ParseObjects(input) {
    let dict = [];
    for (var i = 0; i < input.length; i++) {
        dict.push(JSON.parse(input[i]));
    }
    for (let obj of dict) {
        console.log("Name: " + obj.name);
        console.log("Age: " + obj.age);
        console.log("Date: " + obj.date);
    }
}


ParseObjects([
    '{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}'
])