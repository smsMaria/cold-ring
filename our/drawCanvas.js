const height = 1000;
const width = 1000;
let zoom = 1;
let baseLine = 25;

const container = document.querySelector(".container");
const inputZoom = document.getElementById("inputZoom");

// console.dir(container.clientHeight )

const toScreen = ({ x, y }) => {
    let xScreen = width/2 + x * baseLine * zoom;
    let yScreen = height/2 - y * baseLine * zoom;
    return { x: xScreen, y: yScreen }
};

/*
*  <canvas></canvas>
*
* */
const render = () => {
    const canvas = new Konva.Stage({ container: "root", height, width});
    const layer = new Konva.Layer();

    canvas.add(layer);
    let center = toScreen({x: 0, y: 0});
    for (let y = 1;; y++ ) {
        const point = toScreen({x: 0, y});
        if (point.y < 0) break;
        const lineX = new Konva.Line({ points: [0, point.y, width, point.y], stroke: 'black',
            strokeWidth: 1,
            lineCap: 'round',
            lineJoin: 'round', })
        layer.add(lineX);
    }

    for (let y = -1;; y-- ) {
        const point = toScreen({x: 0, y});
        if (point.y > height) break;
        const lineX = new Konva.Line({ points: [0, point.y, width, point.y], stroke: 'black',
            strokeWidth: 1,
            lineCap: 'round',
            lineJoin: 'round', })
        layer.add(lineX);
    }

    for (let x = 1;; x++ ) {
        const point = toScreen({x, y: 0});
        if (point.x > width) break;
        const lineY = new Konva.Line({ points: [point.x, 0, point.x, height], stroke: 'black',
            strokeWidth: 1,
            lineCap: 'round',
            lineJoin: 'round', })
        layer.add(lineY);
    }

    for (let x = -1;; x-- ) {
        const point = toScreen({x, y: 0});
        if (point.x < 0) break;
        const lineY = new Konva.Line({ points: [point.x, 0, point.x, height], stroke: 'black',
            strokeWidth: 1,
            lineCap: 'round',
            lineJoin: 'round', })
        layer.add(lineY);
    }

    const oX = new Konva.Line({ points: [0, center.y, width, center.y], stroke: 'black',
        strokeWidth: 3,
        lineCap: 'round',
        lineJoin: 'round', })// горизотальная линия
    layer.add(oX);

    const oY = new Konva.Line({ points: [center.x, 0, center.x, height], stroke: 'black',
        strokeWidth: 3,
        lineCap: 'round',
        lineJoin: 'round', })// вертикальная линия
    layer.add(oY);
}

render();


container.scrollTop = container.scrollHeight / 4;
container.scrollLeft = container.scrollWidth / 4;


inputZoom.addEventListener("change", (ev) => {
    zoom = ev.target.value / 100;
    render();
})