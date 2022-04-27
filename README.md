# Klavis

## Setup Instructions

1. Klavis is built on top of .NET 6.0, which requires Visual Studio 2022 specifically. Download an isntall that.
2. With Visual Studio 2022, open the "Klavis.sln" file to open this project.
3. In VS 2022's toolbar, go Tools > Nuget Package Manager > Manage NuGet Packages for Solution.
4. In the Package Masnager, use the Browse tab to dnwload the "Radzen.Blazor" package and Google.Cloud.Firestore" package.
5. Now you should be set to run it.  Press the run button in the Visual Studio tool ribbon and ensure it is running via IIS Express. The web app will automatically open in your default browser.

## User Instructions

1. Login to the Klavis web app - Approved administrators can login with a BU email address to gain access to the Klavis web app. On the site, their unique profile will be displayed in the top right corner

<img width="401" alt="Screen Shot 2022-04-26 at 11 07 31 PM" src="https://user-images.githubusercontent.com/46791493/165431853-481ad212-2bb6-4b3d-8c94-dd22475a6d0e.png">

2. View the Check In page - Here, the admin has full control to create an NFC card for a user, modify a user profile, delete a user, and check if the user has permission to enter the desired location.

<img width="508" alt="Screen Shot 2022-04-26 at 11 10 03 PM" src="https://user-images.githubusercontent.com/46791493/165432111-49c4875b-cd5f-4fff-93de-af596c26fd57.png">

3. Create a user account - If an account has not already been created for a user, the admin can navigate to the “User Management” section and click “Add User”. 

<img width="636" alt="Screen Shot 2022-04-26 at 11 10 44 PM" src="https://user-images.githubusercontent.com/46791493/165432178-56f399e6-3d85-41b7-a053-7baa496648bd.png">

Here, the admin can enter information to create a new user account. 

<img width="642" alt="Screen Shot 2022-04-26 at 11 11 15 PM" src="https://user-images.githubusercontent.com/46791493/165432258-3bc8f4ba-c863-4707-bea9-2d39365d7ea6.png">

4. Create an NFC card - After creating an account, the admin can create a card for the user. On the user management page, any user without a card attached to their account will display a red card icon. Clicking this icon will redirect you to the card creation page. After creating their card, the associated user will receive a download link for the card at the supplied email address. The user may open this link and add the NFC card to their phone's mobile wallet.

<img width="500" alt="Screen Shot 2022-04-26 at 11 11 49 PM" src="https://user-images.githubusercontent.com/46791493/165432315-12ebb687-23c3-41ab-9127-057618951051.png">

5. Add a card to an account - To keep card credentials safe, neither admins nor users are allowed to see card data. To successfully associate a user’s NFC card with an account, an admin must navigate to the User Management section and press “Modify” on a given user. Click inside of the “Scan Card” box to accept card input. Scan the user card to associate the user account. 

![scan_card](https://user-images.githubusercontent.com/46791493/165432411-096159f2-1a73-4b82-80c1-da09f9e8bc0c.gif)

6. Check History - On the “Check In” page, there is an active history log for admins to view who has scanned their card  at a specific location. Admins have the option to select the location and number of entries they wish to view in the history log. Admins can also explore the history of other locations on the “History” page.

<img width="614" alt="Screen Shot 2022-04-26 at 11 13 39 PM" src="https://user-images.githubusercontent.com/46791493/165432501-a549aa9e-c2e0-4488-b302-34626017b9be.png">

7. Add/Remove/Modify access privileges - On the “User Management” tab, admins can manage all users, including their Name , ID,  card information, and access privileges. Press the “Modify” button to edit a user. 

<img width="629" alt="Screen Shot 2022-04-26 at 11 14 09 PM" src="https://user-images.githubusercontent.com/46791493/165432572-94172504-d1ed-4111-a067-6e352bd00064.png">






