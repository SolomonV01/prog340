import * as THREE from "three";

var height = window.innerHeight;
var width = window.innerWidth;

const renderer = new THREE.WebGL1Renderer();
renderer.setSize(width, height);

document.body.appendChild(renderer.domElement);

const scene = new THREE.Scene();