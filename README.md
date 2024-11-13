מערכת לניהול פגישות ייעוץ עבור יועצים פרטיים:

 יועצים (Consultants)
•	GET /api/consultants – קבלת רשימת כל היועצים
•	GET /api/consultants/{id} – קבלת פרטי יועץ מסוים לפי מזהה (ID)
•	POST /api/consultants – הוספת יועץ חדש
•	PUT /api/consultants/{id} – עדכון פרטי יועץ לפי מזהה (ID)
•	DELETE /api/consultants/{id} – מחיקת יועץ לפי מזהה (ID)
לקוחות (Clients)
•	GET /api/clients – קבלת רשימת כל הלקוחות
•	GET /api/clients/{id} – קבלת פרטי לקוח מסוים לפי מזהה (ID)
•	POST /api/clients – הוספת לקוח חדש
•	PUT /api/clients/{id} – עדכון פרטי לקוח לפי מזהה (ID)
•	DELETE /api/clients/{id} – מחיקת לקוח לפי מזהה (ID)
פגישות (Appointments)
•	GET /api/appointments – קבלת רשימת כל הפגישות
•	GET /api/appointments/{id} – קבלת פרטי פגישה מסוימת לפי מזהה (ID)
•	POST /api/appointments – יצירת פגישה חדשה בין יועץ ללקוח (כולל תאריך ושעה)
•	PUT /api/appointments/{id} – עדכון פרטי פגישה לפי מזהה (ID) (למשל, שינוי תאריך/שעה או סטטוס)
•	DELETE /api/appointments/{id} – מחיקת פגישה לפי מזהה (ID)

