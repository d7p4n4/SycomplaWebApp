
// Give the service worker access to Firebase Messaging.
importScripts('https://www.gstatic.com/firebasejs/7.12.0/firebase-app.js');
importScripts('https://www.gstatic.com/firebasejs/7.12.0/firebase-messaging.js');

// Initialize the Firebase app in the service worker by passing in the messagingSenderId.
var config = {
    apiKey: "AIzaSyCHxM0wUG13SqWO1-3sz6qH55klT9o63U4",
    authDomain: "onlyhttp-efac3.firebaseapp.com",
    databaseURL: "https://onlyhttp-efac3.firebaseio.com",
    projectId: "onlyhttp-efac3",
    storageBucket: "onlyhttp-efac3.appspot.com",
    messagingSenderId: "217834076564",
    appId: "1:217834076564:web:87be1f703dd42075ccf781",
    measurementId: "G-E5Z8M1PNK2"
};
firebase.initializeApp(config);

// Retrieve an instance of Firebase Data Messaging so that it can handle background messages.
const messaging = firebase.messaging()
messaging.setBackgroundMessageHandler(function(payload) {

    messaging.getToken().then((currentToken) => {
        if (currentToken) {
            console.log(currentToken);
            postDummyString(currentToken);
        }
    });

    console.log(payload);
  const notificationTitle = 'Data Message Title';
  const notificationOptions = {
    body: 'Data Message body',
    icon: 'alarm.png'
  };
  
  return self.registration.showNotification(notificationTitle,
      notificationOptions);
});