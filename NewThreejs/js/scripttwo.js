import * as THREE from "three";
import { OrbitControls } from 'three/examples/jsm/controls/OrbitControls.js'
import * as dat from 'dat.gui';
import background from '../img/background.jpg'; // Credit: <a href="https://www.freepik.com/free-photo/abstract-flowing-neon-wave-background_15474089.htm#query=background&position=26&from_view=keyword">Image by rawpixel.com</a> on Freepik
import stars from '../img/stars.jpg'; //https://www.pxfuel.com/en/free-photo-obmtg/download

import oneDice from '../img/one.jpg';
import twoDice from '../img/two.JPG';
import threeDice from '../img/three.JPG';
import fourDice from '../img/four.JPG';
import fiveDice from '../img/five.JPG';
import sixDice from '../img/six.JPG';
import { TextureLoader } from "../../SETUP_DEMO/js/three";

const height = window.innerHeight;
const width = window.innerWidth;

const renderer = new THREE.WebGLRenderer();
renderer.shadowMap.enabled = true;
renderer.setSize(width, height);
document.body.appendChild(renderer.domElement);

const scene = new THREE.Scene();
//renderer.setClearColor(0x334455);
//const textureLoader = new THREE.TextureLoader();
//scene.background = textureLoader.load(background);

const cubeLoader = new THREE.CubeTextureLoader();
scene.background = cubeLoader.load([background,stars,stars,stars,stars,stars]);

const camera = new THREE.PerspectiveCamera(45, width / height, 0.1, 1000);
camera.position.set(-10, 30, 30);

const axesHelper = new THREE.AxesHelper(5);
scene.add(axesHelper);

const gridHelper = new THREE.GridHelper(30);
scene.add(gridHelper);

camera.position.set(-10, 30, 30);
orbit.update();

//green box
const boxGeo = new THREE.BoxGeometry();
const boxMat = new THREE.MeshBasicMaterial({ color: 0x00FF00 });
const box = new THREE.Mesh(boxGeo, boxMat);
scene.add(box);

const box2Geo = new THREE.BoxGeometry(4, 4, 4);
const box2Mat = new THREE.MeshBasicMaterial({color: 0xFF0000, map: TextureLoader.load(stars)})
const box2 = new THREE.Mesh(box2Geo, box2Mat);
scene.add(box2);

//Floor
const planeGeo = new THREE.PlaneGeometry(30, 30)
const planeMat = new THREE.MeshStandardMaterial({ color: 0xFFFFFF, side: THREE.DoubleSide });
const plane = new THREE.Mesh(planeGeo, planeMat);
scene.add(plane);
plane.rotation.x = -Math.PI/2;
plane.receiveShadow = true;

//Sphere
const sphereGeo = new THREE.SphereGeometry(4, 40, 40);
const sphereMat = new THREE.MeshStandardMaterial({ color: 0x0000FF, wireframe: false });
const sphere = new THREE.Mesh(sphereGeo, sphereMat);
scene.add(sphere);
sphere.position.set(-10, 10, 0);
sphere.castShadow = true;

//Ambient
const ambientLight = new THREE.AmbientLight(0x333333);
scene.add(ambientLight);

//Spot
const spotLight = new THREE.SpotLight(0xFFFFFF);
scene.add(spotLight);
spotLight.position.set(-20,20,0);
spotLight.castShadow = true;
const spotLightHelper = new THREE.SpotLightHelper(spotLight);
scene.add(spotLightHelper);

//fog
//scene.fog = new THREE.Fog(0xFFFFFF,0,200);
//scene.fog = new THREE.FogExp2(0xFFFFFF, .01);

//spotlight.decay = 0;

const gui = new dat.GUI();
const guiOptions = {
    SphereColor: 0X0000FF,
    wireframe: false,
    speed : 0.01,
    angle: 0.2,
    penumbra: 0,
    intensity : 1
};

gui.addColor(guiOptions, 'SphereColor').onChange(function (color) {
    sphere.material.color.set(color);
});

gui.add(guiOptions, 'wireframe').onChange(function (wireframe) {
    sphere.material.wireframe = wireframe;
});

gui.add(guiOptions, 'speed', 0,.1);
gui.add(guiOptions, 'angle', 0, 1);
gui.add(guiOptions, 'penumbra', 0, 1);
gui.add(guiOptions, 'intensity', 0, 1);

const bounceAngle = 0;

function animate(time) {
    box.rotation.x = time / 1000;
    box.rotation.y = time / 1000;

    bounceAngle += guiOptions.speed;
    sphere.position.y =  10*Math.abs(Math.sin(bounceAngle));

    spotLight.angle = guiOptions.angle;
    spotLight.penumbra = guiOptions.penumbra;
    spotLight.intensity = guiOptions.intensity;
    spotLightHelper.update();

    renderer.render(scene, camera);
}

const box2Materials = [
    new THREE.MeshStandardMaterial({map : textureLoader.Load(oneDice)}),
    new THREE.MeshBasicMaterial({map : textureLoader.Load(twoDice)}),
    new THREE.MeshBasicMaterial({map : textureLoader.Load(threeDice)}),
    new THREE.MeshBasicMaterial({map : textureLoader.Load(fourDice)}),
    new THREE.MeshBasicMaterial({map : textureLoader.Load(fiveDice)}),
    new THREE.MeshStandardMaterial({map : textureLoader.Load(sixDice)})
];

const mousePos = new THREE.Vector2();

window.addEventListener("mousemove", function(e){
    mousePos.x = (e.clientX / width) * 2 - 1;
    mousePos.y = (e.clientY / height) * 2 + 1;
});

const rayCaster = new THREE.Raycaster();
rayCaster.setFromCamera(mousePos, camera);
const intersectObj = rayCaster.intersectObjects(scene.children);
console.log(intersectObj);

for(var i = 0< intersectObj.length; i++;)
{
    if(intersectObj[i].object.id === sphere.id)
    {
        intersectObj[i].object.material.color.set(0xFF000);
    }

    if(intersectObj[i].object.name === box2.name)
    {
        intersectObj[i].object.rotation.x = time / 1000;
        intersectObj[i].object.rotation.y = time /1000;
    }
}

renderer.setAnimationLoop(animate);