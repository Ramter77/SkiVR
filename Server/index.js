var io = require('socket.io')(process.env.PORT || 45678);
console.log('---Server has started---');

//CONNECT
io.on('connection', function(socket) {
    console.log('Connected');
    //console.log(socket);

    //Send data from server to the client (here: send "register")
    socket.emit('register');
    //Data can only be sent as JSON objects which is the "key:" & "value" pair in the {} below
    //socket.emit('register', {id: "1"});


    socket.emit('start');



    //Sends it to every connected socket except for itself (IGNORE FOR NOW)
    //socket.broadcast
    

    //When it receives "hello" it executes the function below
    socket.on('hello', function() {
        console.log("hello from VR");
    });



    //DISCONNECT
    socket.on('disconnect', function() {
        console.log("Disconnected");
    });
});