import { SecretWord } from "./secretword";
import { HangedMan } from "./hangedman";

const canvas: HTMLCanvasElement = <HTMLCanvasElement>document.getElementById("canvas");
const ctx: CanvasRenderingContext2D = canvas.getContext('2d');

const newWordBtn: HTMLButtonElement = <HTMLButtonElement>document.getElementById('newWordBtn');

const hangedMan = new HangedMan(ctx);

newWordBtn.onclick = function () {
    ctx.fillStyle = "#000000";
    ctx.fillRect(0, 0, canvas.width, canvas.height);
    charArr = [];
    init();
    hp = 5;
    incorrectLetters = "";
}

var maxWordLength = 100;
var minWordLength = 1;

var hp: number = 5;

var charArr = [];
var cWord: string;
var incorrectLetters: string = "";

canvas.width = 1200;
canvas.height = 500;

async function init() {
    var response = await SecretWord.getWord(maxWordLength, minWordLength)
    cWord = response.data.words[0].toString();

    ctx.fillStyle = "#FFFFFF";
    ctx.font = '50px Chakra Petch';

    for (let i = 0; i < cWord.length; i++) {
        charArr.push(cWord.charAt(i));
    }

    console.log(cWord);
    cWord = cWord.replace(/./g, '_');
    ctx.fillText((hp + 1).toString(), 10, canvas.height - 70);
    ctx.fillText(cWord, 10, 70);

}

document.addEventListener('keydown', (event: KeyboardEvent) => {
    var keyName = event.key.toLowerCase();
    

    if (!(/[a-z]/.test(keyName)) || keyName.length > 1) { return; }

    if (hp == 0) {
        hangedMan.draw(hp);
        clearCanvas();
        ctx.fillStyle = "#FFFFFF";
        ctx.fillText(charArr.join(''), 10, 70);
        return;
    }

    clearCanvas();
    

    var guessedCorrectly: boolean = false;
    for (let i = 0; i < cWord.length; i++) {
        if (keyName == charArr[i]) {
            cWord = setCharAt(cWord, i, charArr[i]);
            guessedCorrectly = true;
        }
    }

    if (!guessedCorrectly && !(incorrectLetters.includes(keyName))) {
        hangedMan.draw(hp);
        hp--;
        incorrectLetters += keyName;
    }


    ctx.fillStyle = "#FFFFFF";
    ctx.fillText(cWord, 10, 70);
    ctx.fillText((hp + 1).toString(), 10, canvas.height - 70);
    ctx.fillText(incorrectLetters, 10, canvas.height - 20);


    if (isComplete()) {
        clearCanvas();
        ctx.font = '200px Chakra Petch';
        ctx.fillStyle = "#FFFFFF";
        ctx.fillText("wowie", (canvas.width / 2) - 450, canvas.height / 2);
    }
});


function setCharAt(str, index, chr) : string {
    return str.substr(0, index) + chr + str.substr(index + 1);
}

function isComplete(): boolean {
    return !cWord.includes("_");
}

function clearCanvas() : void{
    ctx.fillStyle = "#000000";
    ctx.fillRect(0, 0, canvas.width-250, canvas.height);
}

init();