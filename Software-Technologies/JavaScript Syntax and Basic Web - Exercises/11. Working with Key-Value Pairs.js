function KeyValuePairs(input) {
    let arr = [];
    for (var i = 0; i < input.length-1; i++) {
       let splitInput = input[i].split(' ');
       var key = splitInput[0];
       let value = splitInput[1];
       arr[key] = value;
    }
    let printKey = input[input.length-1];
   if(arr[printKey] == undefined){
       console.log("None")
   }else{
       console.log(arr[printKey])
   }
}

KeyValuePairs([
    "3 bla",
    "3 alb",
    "2"
])