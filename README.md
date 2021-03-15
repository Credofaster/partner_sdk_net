# Getting started

Buy Airtime on the most simplistic System. We abstract all the nitty-gritty leaving you with just the option to specify the account number to receive airtime and how much. 

We guarantee 95% uptime, 99% reliability.

Just Request and we will make sure you get, in realtime. If not, you will be notified immediately by events.

Now, what Credo is faster that Credofaster!

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (CredofasterPartnerApi.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Credofaster%20Partner%20Api-CSharp&workspaceName=CredofasterPartnerApi&projectName=CredofasterPartnerApi.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the CredofasterPartnerApi library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Credofaster%20Partner%20Api-CSharp&workspaceName=CredofasterPartnerApi&projectName=CredofasterPartnerApi.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Credofaster%20Partner%20Api-CSharp&workspaceName=CredofasterPartnerApi&projectName=CredofasterPartnerApi.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Credofaster%20Partner%20Api-CSharp&workspaceName=CredofasterPartnerApi&projectName=CredofasterPartnerApi.Standard)

### 3. Add reference of the library project

In order to use the CredofasterPartnerApi library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Credofaster%20Partner%20Api-CSharp&workspaceName=CredofasterPartnerApi&projectName=CredofasterPartnerApi.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` CredofasterPartnerApi.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```CredofasterPartnerApi.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Credofaster%20Partner%20Api-CSharp&workspaceName=CredofasterPartnerApi&projectName=CredofasterPartnerApi.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Credofaster%20Partner%20Api-CSharp&workspaceName=CredofasterPartnerApi&projectName=CredofasterPartnerApi.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| apiKey | Assigned APIKey |
| clientId | Assigned ClientId |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string apiKey = "XXXX-XXXX-XXXX-XXXX"; // Assigned APIKey
string clientId = "ABCDEDFG1234"; // Assigned ClientId

CredofasterPartnerApiClient client = new CredofasterPartnerApiClient(apiKey, clientId);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [MainController](#main_controller)
* [EventsController](#events_controller)

## <a name="main_controller"></a>![Class: ](https://apidocs.io/img/class.png "CredofasterPartnerApi.Standard.Controllers.MainController") MainController

### Get singleton instance

The singleton instance of the ``` MainController ``` class can be accessed from the API Client.

```csharp
MainController main = client.Main;
```

### <a name="airtime_request"></a>![Method: ](https://apidocs.io/img/method.png "CredofasterPartnerApi.Standard.Controllers.MainController.AirtimeRequest") AirtimeRequest

> Request Airtime Purchase


```csharp
Task<List<Models.PartnerAirtimeResponse>> AirtimeRequest(Models.PartnerAirtimeRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.PartnerAirtimeRequest();

List<Models.PartnerAirtimeResponse> result = await main.AirtimeRequest(request);

```


### <a name="airtime_balance"></a>![Method: ](https://apidocs.io/img/method.png "CredofasterPartnerApi.Standard.Controllers.MainController.AirtimeBalance") AirtimeBalance

> Gets the current Working Balance. 
> Balance is SIGNED


```csharp
Task<Models.PartnerAirtimeBalanceResponse> AirtimeBalance()
```

#### Example Usage

```csharp

Models.PartnerAirtimeBalanceResponse result = await main.AirtimeBalance();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="events_controller"></a>![Class: ](https://apidocs.io/img/class.png "CredofasterPartnerApi.Standard.Controllers.EventsController") EventsController

### Get singleton instance

The singleton instance of the ``` EventsController ``` class can be accessed from the API Client.

```csharp
EventsController events = client.Events;
```

### <a name="register_callback"></a>![Method: ](https://apidocs.io/img/method.png "CredofasterPartnerApi.Standard.Controllers.EventsController.RegisterCallback") RegisterCallback

> A callback to receive the below Callbacks


```csharp
Task<Models.RegisterCallbackResponse> RegisterCallback(Models.RegisterCallbackRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.RegisterCallbackRequest();

Models.RegisterCallbackResponse result = await events.RegisterCallback(request);

```


### <a name="client_event_feedback"></a>![Method: ](https://apidocs.io/img/method.png "CredofasterPartnerApi.Standard.Controllers.EventsController.ClientEventFeedback") ClientEventFeedback

> *Tags:*  ``` Skips Authentication ``` 

> You are required to provide a HTTP/HTTPS endpoint, to which we will publish various events. 
> 
> This Endpoint will be hosted on the CLIENT's Environment. If no endpoint is provided, we are not liable to any missing events. 
> 
> NOTE: A DETAILED PDF of all Events is shared on request. It contains application events, System Health Events and Alerts on the same.


```csharp
Task<Models.EventCallbackFeedback> ClientEventFeedback(Models.EventCallbackPayload payloadToReceive)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| payloadToReceive |  ``` Required ```  | Sample Payload: {"EventId":"123456789","EventType":"QUEUED","RequestId":"A09797a11e2564061b859781b18bb34dd","EventData":{}} |


#### Example Usage

```csharp
string payloadToReceiveValue = "{\"EventId\":\"123456789\",\"EventType\":\"QUEUED\",\"RequestId\":\"A09797a11e2564061b859781b18bb34dd\",\"EventData\":{}}";
var payloadToReceive = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.EventCallbackPayload>(payloadToReceiveValue);

Models.EventCallbackFeedback result = await events.ClientEventFeedback(payloadToReceive);

```


[Back to List of Controllers](#list_of_controllers)



