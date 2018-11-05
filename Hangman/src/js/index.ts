import axios from "axios";

const canvas: HTMLCanvasElement = <HTMLCanvasElement>document.getElementById("canvas");
const ctx: CanvasRenderingContext2D = canvas.getContext('2d');

//const newWordBtn : HTMLButtonElement = <HTMLButtonElement>document.getElementById('newWordBtn');
const newWordBtn = document.getElementById("newWordBtn") as HTMLButtonElement;

newWordBtn.onclick = function() {
    ctx.fillStyle = "#000000";
    ctx.fillRect(0,0, canvas.width, canvas.height);
    charArr = [];
    init();
    hp = 6;
    incorrectLetters = "";
}

var maxWordLength = 100;
var minWordLength = 1;

var hp : number = 6;

var charArr = [];
var cWord: string;
var incorrectLetters : string = "";

canvas.width = 1200;
canvas.height = 500;

function init(): void {
    axios.get('http://api.evang.dk/randomwords/', {
        'headers':
        {
            'numberOfWords': 1,
            'maxWordLength': maxWordLength,
            'minWordLength': minWordLength,
        }
    })
        .then(function (response) {
            cWord = response.data.words[0].toString();

            ctx.fillStyle = "#FFFFFF";
            ctx.font = '50px Chakra Petch';

            for (let i = 0; i < cWord.length; i++) {
                charArr.push(cWord.charAt(i));
            }
            console.log(cWord);
            cWord = cWord.replace(/./g, '_');
            ctx.fillText(hp.toString(), 10, canvas.height-70);
            ctx.fillText(cWord, 10, 70);
        });
}

document.addEventListener('keydown', (event: KeyboardEvent) => {
    if (hp == 0) { 
        ctx.fillStyle = "#000000";
        ctx.fillRect(0,0, canvas.width, canvas.height);
        ctx.fillStyle = "#FFFFFF";
        ctx.fillText(charArr.join(''), 10, 70);
        return; 
    }

    ctx.fillStyle = "#000000";
    ctx.fillRect(0,0, canvas.width, canvas.height);
    var keyName = event.key.toLowerCase();

    var guessedCorrectly : boolean = false;
    for (let i = 0; i < cWord.length; i++){
        if (keyName == charArr[i]){
            cWord = setCharAt(cWord, i, charArr[i]);
            guessedCorrectly = true;
        }
    }
    
    if (!guessedCorrectly && !(incorrectLetters.includes(keyName))){
        console.log(incorrectLetters.includes(keyName))
        hp--;
        incorrectLetters += keyName;
    }


    ctx.fillStyle = "#FFFFFF";
    ctx.fillText(cWord, 10, 70);
    ctx.fillText(hp.toString(), 10, canvas.height-70);
    ctx.fillText(incorrectLetters, 10, canvas.height-20);


    if (isComplete()){
        ctx.fillStyle = "#000000";
        ctx.fillRect(0,0, canvas.width, canvas.height);
        ctx.font = '200px Chakra Petch';
        ctx.fillStyle = "#FFFFFF";
        ctx.fillText("wowie", (canvas.width/2)-450, canvas.height/2);
    }
});


function setCharAt(str,index,chr) {
    return str.substr(0,index) + chr + str.substr(index+1);
}

function isComplete():boolean{
    return !cWord.includes("_");
}

init();