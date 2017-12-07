Typically, services describe business logic for a given domain in the application.

You should create interfaces for the Service and then implement then within the same project. The interface allows anything else (i.e tests) to create their own implementation
for the given interface without breaking the flow of the application