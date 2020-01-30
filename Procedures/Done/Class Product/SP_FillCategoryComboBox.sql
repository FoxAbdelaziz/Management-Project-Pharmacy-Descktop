Create Procedure SP_FillCategoryComboBox
AS
  Select ca.Cat_ID ,ca.Cat_Name From TblCategory Ca
Return 