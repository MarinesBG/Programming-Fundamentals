function LargestNumbers(input) {
    let spilitInput = input;

    spilitInput.sort((a,b) => a - b);

    for (var i =  spilitInput.length-1; i > (spilitInput.length-1)- 3; i--) {
        if(i < 0){
            break;
        }
        console.log(spilitInput[i])
    }
}

LargestNumbers([
    10, 1, 2, 5, 23,
]);