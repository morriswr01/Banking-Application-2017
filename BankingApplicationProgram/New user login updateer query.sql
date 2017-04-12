INSERT INTO tbl_Customer ([First Name],[Last Name],[Gender],[Date Of Birth],[House Address]) VALUES ('callum','say','male','14/12/98','14 wood drive')

INSERT INTO tbl_Login (username,password,customerID) VALUES ('saycm01','callum',(SELECT customerID FROM tbl_Customer WHERE [First Name]='callum' AND [Last Name]='say' AND [Gender]= 'male' AND [Date Of Birth]='14/12/98' AND [House Address]='14 wood drive'))

SELECT CustomerID FROM tbl_customer WHERE [First Name]='Jayson' AND [Last Name]= 'Hood' 