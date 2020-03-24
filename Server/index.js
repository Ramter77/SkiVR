var io = require('socket.io')(process.env.PORT || 45678);
console.log('---Server has started---');

//CONNECT (.on means it's coming from the client to the server)
io.on('connection', function(socket) {
    console.log('Connected');

    //Send data from server to the client
    //socket.emit('register', {id: "1"});
    socket.emit('start');

    //Sends it to every connected socket except for itself
    //socket.broadcast

    //DISCONNECT
    socket.on('disconnect', function() {
        console.log("Disconnected");
    });
});




//document.querySelector().addEventListener