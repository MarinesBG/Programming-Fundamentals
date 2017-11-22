function MultipleValuesForKey(input) {
    let dict = [];
    for (var i = 0; i < input.length-1; i++) {
        let splitInput = input[i].split(' ');
        let keys = splitInput[0];
        let values = splitInput[1];
        dict.push({Key: keys, Value: values});
    }
    let printKey = input[input.length-1];
    let count = 0;
    for (var j = 0; j< dict.length; j++) {
        if(dict[j].Key == printKey){
            console.log(dict[j].Value)
            count++;
        }
    }
    if(count == 0){
        console.log("None")
    }
}


MultipleValuesForKey([
    "3 test",
    "3 test1",
    "4 test2",
    "4 test3",
    "4 test5",
    "4"
])