### Verse of The Day Web App Challenge ###
#### Date: 04/12/2021 ####
#### Author: Armando Fernandez #### 
#### Email: codefilez@gmail.com ####
#### Description: This was a take-home challenge given to me in an interview round. The requirements below are exactly what the interviewees provided me with. The company was a Christian based radio station.
#### ***IMPORTANT***: Before running the project, you must define the HEADER KEY & VALUE, required by the Verse of the Day API Definition, as they key and its value where excluded to prevent exposure in Github. ####
####
- You can define the values for the key and value in file KLOVE_Mando/Models/Bible.cs (lines 47 & 48).
- A minimum requirement would be to have a local SQL Express Instance available when running the project, as Code First will create the database in the local instance.
- Functionality -The application's homepage contains a form with a start date field for the user to select a start date, number of verses to display and submit button.
- Once the user submits the start date and number of verses to display, the server will make an API call to the GetVerses endpoint and return the results to the user.
- The user can then select verses to favorite, favorited verses are stored in the database.-The user can visit the My Favorites page to view all the verses they have favorited.####

***Challenge Requirements***: 
- [x] Use Entity Framework to manage the database.
- [x] The API definition is shown below make sure you copy the url correctly and fully.
- [x] Once you are done, upload your code to github. 
- [x] You must include instructions on how to run your application successfully.
- [x] A pleasant UI is a bonus.
