private void calculateButton_Click(object sender, EventArgs e)
{
    try
    {
        double miles = double.Parse(milesTextBox.Text);
        double gallons = double.Parse(gallonsTextBox.Text);

        double mpg = miles / gallons;

        mpgLabel.Text = mpg.ToString("n1");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

private void exitButton_Click(object sender, EventArgs e)
{
    this.Close();
}
