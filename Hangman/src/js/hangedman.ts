//This must be the work of an enemy [[[STAND]]]!!!
export class HangedMan {
    private ctx : CanvasRenderingContext2D;

    constructor(ctx : CanvasRenderingContext2D){
        this.ctx = ctx;
    }

    draw(hp: number): void {
        this.ctx.fillStyle = "#FFFFFF";
        this.ctx.strokeStyle = "#FFFFFF";
        this.ctx.lineWidth = 5;
        switch (hp) {
            case 5:
                this.head();
                break;
            case 4:
                this.body();
                break;
            case 3:
                this.rightArm();
                break;
            case 2:
                this.leftArm();
                break;
            case 1:
                this.rightLeg();
                break;
            case 0:
                this.leftLeg();
                break;
            default:
                break;
        }
    }

    leftLeg(): void {
        this.ctx.beginPath();
        this.ctx.moveTo(1080, 220);
        this.ctx.lineTo(1060, 320);
        this.ctx.stroke();
    }

    rightLeg(): void {
        this.ctx.beginPath();
        this.ctx.moveTo(1080, 220);
        this.ctx.lineTo(1100, 320);
        this.ctx.stroke();
    }

    leftArm(): void {
        this.ctx.beginPath();
        this.ctx.moveTo(1075, 135);
        this.ctx.lineTo(1030, 200);
        this.ctx.stroke();
    }

    rightArm(): void {
        this.ctx.beginPath();
        this.ctx.moveTo(1085, 135);
        this.ctx.lineTo(1130, 200);
        this.ctx.stroke();
    }

    body(): void {
        var x = 1080;
        var y = 180;
        var width = 50;
        var height = 100;
        this.ctx.beginPath();
        this.ctx.moveTo(x, y - height/2);

        this.ctx.bezierCurveTo(x + width/2, y - height/2, x + width/2, y + height/2, x, y + height/2);
        this.ctx.bezierCurveTo(x - width/2, y + height/2, x - width/2, y - height/2, x, y - height/2);
        
        this.ctx.fill();
    }

    head(): void {
        this.ctx.beginPath();
        this.ctx.moveTo(1080, 0);
        this.ctx.lineTo(1080, 100);
        this.ctx.stroke();
        this.ctx.beginPath();
        this.ctx.arc(1080,100,30,0,Math.PI*2,false);
        this.ctx.fill();
    }
}