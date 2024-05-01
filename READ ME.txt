Matching Your Bases uses an external database using a Wampserver to store highscores. Inorder to access this feature you will need to follow the instructions below to set up a local database

Step 1. Install wamp onto your computer

Step 2. Go to your phpmyadmin (default should be localhost/phpmyadmin/)

Step 3. Use the username root with no password to log in.

Step 4. Navigate to the databases tab at the top of your screen

Step 5. in the Field for Database name enter matching_your_bases (This is case sensitive) then click create

Step 6. You should now be in the create new table section. Under Table name enter the name score (this is case sensitive) and set the number of Columns to 3 then click create.

Step 7. Under the Name field, from top to bottom, enter the names Name, Time, and Game (case sensitive)

Step 8. Next to Name change the type to VARCHAR and the Length to 255

Step 9. If Time and Game are not set to type INT then change them to it.

Step 10. Click Save

Step 11. Navigate to your wamp64 file. By default it is C:\wamp64 and open the www folder.

Step 12. Create a folder in the www folder named Matching_Your_Bases (case sensitive)

Step 13. In the folder in Github Titled Matching_Your_Bases download the .php files and place them into the folder you created in step 12.
