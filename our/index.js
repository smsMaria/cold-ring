const bg = document.querySelector(".container");
const inputDemons = document.getElementById("inputCoorDemons");
const inputCountDemons = document.getElementById("inputCountDemons");

let arrCoor = [];

const toObj = (arr) => {
    let newArr = arr.split("")
    return {x: newArr[1], y: newArr[3]}
}

// bg.addEventListener("click", (ev) => {
//     let arr = inputDemons.value.split(" ");
//     arr.forEach((el) => {
//         arrCoor.push(toObj(el))
//     })
//     console.log(arrCoor)
// })


/*

(2,3) (5,6) (4,8)

"(" '2' ',' "3" ")"
0    1   2   3   4


(2) ['1.6', '5.3']
        0: "1.6"
        1: "5.3"



0  "2.1"
1  "2.3"
2  "5.6"

[{x: 5, y: 6}, {x: 1, y: 9}, {x: 6, y: 7}]

 */