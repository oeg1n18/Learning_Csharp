
Authentication:
the process of verifying the identity of a user by validating their credentials against  some authority. 
Credentials include, usename, password or biometrics. 


Authorization: 
The process of verifying membership of groups or roles before allowing access to resources such as application functions and data.


Methods: 
There are multiple authentication and authorisation methods in System.Security.Principal namespace. They implement 
a pair of interfaces. IIdentity and IPrincipal. The IIDentity represents a user, so it has a Name property and an
ISAuthenticated property to indicate if they are anonymous or if they have been successfully authenticated from their 
creentials. 

