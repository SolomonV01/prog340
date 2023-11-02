import * as THREE from "three";
import { testElement } from "domutils";

var height = window.innerHeight;
var width = window.innerWidth;

const renderer = new THREE.WebGLRenderer();
renderer.shadowMap.enabled = true;
renderer.setSize(width, height);
document.body.appendChild(renderer.domElement);

const camera = new THREE.PerspectiveCamera(45, width / height, 0.1, 1000);
const orbit = new OrbitControls(camera, renderer.domElement);

const axesHelper = new THREE.AxesHelper(5);
scene.add(axesHelper);
const gridHelper = new THREE.GridHelper(30);
scene.add(gridHelper);

camera.position.set(-10, 30, 30);
this.camera.position.z = 128;
orbit.update();

const scene = new THREE.Scene();

const sunGeometry = new THREE.BoxGeometry(8, 8, 8);
const sunMaterial = new THREE.MeshNormalMaterial();
const sunMesh = new THREE.Mesh(sunGeometry, sunMaterial);
const solarSystem = new THREE.Group();
solarSystem.add(sunMesh);

