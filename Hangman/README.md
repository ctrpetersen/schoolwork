# Pong game built with TypeScript
You can see the project running on this page: http://evang.dk/pong-typescript/

This project is based on a template for webpack/Typescript development: https://github.com/dimselab/Webpack-template
The project is meant as an example of using interfaces and objects in typescript 

### Prerequisites
You neet a recent installation of Node on your computer

### Installing
install all dependencies (node modules)
```console
npm install
```

### Start Developing
You run the project example in the src folder
```console
npm run watch
```
Your browser should no show the index.htm and automatically refresh when you do changes in the src folder.
Remember that your src files are automatically transpiles and or copied to the dist folder and then showed from there

### Deployment
When your project is ready for deployment you should use webpack in production mode by writing this in the console
```console
npm run webpack:prod
```
That will minify your code and make is production ready

### Author
Ebbe Vang
