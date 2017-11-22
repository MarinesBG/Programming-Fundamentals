function SumNumbers(input) {
   let objs = input.map(JSON.parse);
   let objsSum = {}
    for (let obj of objs) {
        if(obj.town in objsSum){
          objsSum[obj.town] += obj.income;
        }else{
          objsSum[obj.town] = obj.income;
        }
    }
    let twons = Object.keys(objsSum).sort();
    for (let town of twons) {
        console.log(`${town} -> ${objsSum[town]}`);
    }
}

SumNumbers([
'{"town":"Sofia","income":200}',
'{"town":"Varna","income":120}',
'{"town":"Pleven","income":60}',
'{"town":"Varna","income":70}'
]);