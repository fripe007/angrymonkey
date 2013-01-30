angrymonkey
===========

Angry Monkey is a cross platform framework to allow complete separation of concerns between Mono and (Java/Objective C)

Using open source framework such as MonoCross and Calbash, the framework allows you to author your business logic with C# for multi platform distribution whilst keeping the UI 100% native.

At present the framework consists of a set of example soloutions which demonstrate how to setup MonTouch and MonoDroid with standard XCode and Eclipse project files.

Originally the intention was to embed mono inside of the native application but due to packaging issues especially with iOS this is not possible.  Instead a MonoTouch / MonoDroid shim has been created which then loads the UI from an Android or iOS library.

Utilising an MVP approach which has the V and the P loosely coupled using the observable pattern it has been possible to completely segregate the buisness logic from the UI which enables us to code our business logic and model with mono C# giving complete re-use across many platforms.

Although this implementaion concerns iOS and Android there are plans to extend the approach to Windows mobile and even Web.


Installation Instructions:

-- Install Xcode and MacOSX Xcode Tools

-- Install Eclipse

-- Install the 

-- Install Mono

-- Install MonoDevelop

-- Install MonoTouch

-- Install MonoDroid

-- Install Calabash for Mac OSX
>> sudo gem install calabash-android
>> sudo gem install calabash-ios

-- Clone this git repository

-- Run the configure script and follow the prompts
The configure script will change the default namespace co.yat.* to your custom namespace and application name

-- Test build
From the root directory run
>> ant debugAll
or to test only one platform
>> ant debugiOS
>> ant debugAndroid

This will generate the simple two view example and execute the tests for the selected configuration.

Calabash Notes

Android:

For the test server to run you must add the internet permission to your manafest like so...
<uses-permission android:name="android.permission.INTERNET" />

In order to run calabash the server must be signed with the same file that is used by monodevelop or the applicaiton will fail, add a .calabash_settings file to the root where you run your tests from with the following details
{"keystore_location":"~/.local/share/Xamarin/Mono for Android/debug.keystore","keystore_password":"android","keystore_alias":"androiddebugkey","keystore_alias_password":"android"}

After this has been compelted you must build the server before running
calabash-android build [path to your file]-Signed.apk
calabash-android run [path to your file]-Signed.apk