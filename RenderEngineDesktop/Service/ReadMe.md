# Service versions
The public API for Render-Engine-Refactor has changed.
As such there are now two versions:

* v1: Original RES API
* v2: New RES API

## New Changes
CultureName parameter is now part of all API calls.

## Create RenderEngineServiceImplementation
Run the API service you want to pull from.
RES API runs on 

```http://localhost:1400/```

Open command prompt to:

```C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools```

Run the following command:

```svcutil.exe http://localhost:1400/?wsdl```

It will generate two files.  You want:

```RenderEngineServiceImplementation.cs```


