#!/bin/bash

# Replace with your specific values
app_name="your-app-name"
subscription_id="your-subscription-id"
resource_group="your-resource-group"
publish_profile_path="/path/to/your/publish-profile.pub"

# Build the application
dotnet publish -c Release -o publish

# Deploy to Azure App Service
az webapp deployment source config-local-git \
  --name $AssessmentApp \
  --resource-group $DOT503\
  --publish-local-path publish \
  --scm-type "LocalGit" \
  --publish-profile $publish_profile_path

echo "Deployment completed successfully"
