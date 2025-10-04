# Azure Function Project

This project is an Azure Function that reads messages from an Azure Service Bus Queue. Below are the instructions on how to set up and run the function locally.

## Prerequisites

- .NET SDK (version 3.1 or later)
- Azure Functions Core Tools
- An Azure Service Bus namespace and queue

## Setup

1. Clone the repository or download the project files.
2. Open a terminal and navigate to the project directory.
3. Restore the project dependencies by running:
   ```
   dotnet restore
   ```

4. Update the `local.settings.json` file with your Azure Service Bus connection string and queue name.

## Running the Function Locally

To run the Azure Function locally, use the following command in the terminal:

```
func start
```

This will start the Azure Functions runtime and listen for messages on the configured Service Bus Queue.

## Deployment

To deploy the function to Azure, use the Azure Functions extension in your preferred IDE or use the Azure CLI.

## License

This project is licensed under the MIT License.