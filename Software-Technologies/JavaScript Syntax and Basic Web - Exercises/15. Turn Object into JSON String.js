function TurnObjectInString(input) {
    let obj = {};
    for (var i = 0; i < input.length; i++) {
        let splitInput = input[i].split(" -> ");
        if(splitInput[0] === "name"){
            obj.name = splitInput[1];
        }else if(splitInput[0] == "surname"){
            obj.surname = splitInput[1];
        }else if(splitInput[0] == "age"){
            obj.age = Number(splitInput[1]);
        }else if(splitInput[0] == "grade"){
            obj.grade = Number(splitInput[1]);
        }else if(splitInput[0] == "date"){
            obj.date = splitInput[1];
        }else if(splitInput[0] == "town"){
            obj.town = splitInput[1];
        }
    }
    console.log(JSON.stringify(obj))
}


TurnObjectInString([
   "name -> Angel",
   "surname -> Georgiev",
   "age -> 20",
   "grade -> 6.00",
   "date -> 23/05/1995",
   "town -> Sofia"
])