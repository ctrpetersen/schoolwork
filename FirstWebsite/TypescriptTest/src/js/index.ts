import { Car } from 'cars'

function CarDetails(car:Car):string{
    return car.Brand + " " + car.Model + " " +  car.Year;
}

let carOne:Car = {Brand:"Citröen", Model:"Cactus", Year:"2015"}
let carTwo:Car = {Brand:"Skoda", Model:"Fabia", Year:"2008"}

let element1: HTMLDivElement = <HTMLDivElement> document.getElementById("content1");
let element2: HTMLDivElement = <HTMLDivElement> document.getElementById("content2");
element1.innerHTML = CarDetails(carOne);
element2.innerHTML = CarDetails(carTwo);