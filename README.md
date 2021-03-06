# Skovde.CustomTasks.OpenECallBack

FRENDS Task for integrating with OpenE using their API. NOT ALL TASKS HAVE BEEN TESTED OR DOCUMENTED YET.

[![Actions Status](https://github.com/CommunityHiQ/Skovde.CustomTasks.OpenECallBack/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/CommunityHiQ/Skovde.CustomTasks.OpenECallBack/actions) ![MyGet](https://img.shields.io/myget/frends-community/v/Skovde.CustomTasks.OpenECallBack) [![License: UNLICENSED](https://img.shields.io/badge/License-UNLICENSED-yellow.svg)](https://opensource.org/licenses/UNLICENSED) 

- [Installing](#installing)
- [Tasks](#tasks)
     - [OpenE](#OpenE)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the Task via frends UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/Skovde.CustomTasks.OpenECallBack

# Tasks

## WriteMessageToOpenE

Writes a message to OpenE, takes in DateTime, ExternalID, FlowInstanceID, attachments, a message string and a userID field.

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| Added | `DateTime` | DateTime to specify when the message was added | `DateTime.Now` |
| Attachments | `AttachMents` |  | `` |
| Message | `string` | Message to be written to OpenE | `Hello World` |
| UserID | `string` | UserID that is written to the message, does not need to be an actual user | `FRENDS` |
| Added | `DateTime` | DateTime to specify when the message was added | `DateTime.Now` |
| Id | `string` | Name that will be written along with the message, but not visible in OpenE  | `FRENDS` |
| System | `string` | Required field, but not visible in OpenE UI | `FRENDS` |
| FlowInstanceID | `int` | FlowInstanceID (ticket ID) in OpenE to write the message to | `73` |
| Added | `DateTime` | DateTime to specify when the message was added | `DateTime.Now` |
| Name | `string` | Name that will be written to the message | `DateTime.Now` |
| UserID | `string` | Username that will be written to the message | `DateTime.Now` |

### Options

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| RemoteAddress | `string` | URI to OpenE callback service | `https://your_address_here` |
| UserName | `string` | Username to authenticate to OpenE. | `,` |
| Password | `string` | Password to authenticate to OpenE. | `,` |

### Returns

A string from OpenE with the message ID.

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| Result | `string` | Response from OpenE with the message ID. | `55` |

Usage:
Fill in the necessary data into the task and it should write a message to OpenE. 

`#result`

# Building

Clone a copy of the repository

`git clone https://github.com/CommunityHiQ/Skovde.CustomTasks.OpenECallBack.git`

Rebuild the project

`dotnet build`

Run tests

`dotnet test`

Create a NuGet package

`dotnet pack --configuration Release`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repository on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes |
| ------- | ------- |
| 0.0.1   | Development still going on |
