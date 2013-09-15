' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Imports System.Net.Http.HttpClient
Imports Windows.ApplicationModel.DataTransfer
Imports Windows.UI.ApplicationSettings
Imports Windows.UI.Popups
Imports Windows.UI.Xaml.Navigation

Public NotInheritable Class MainPage
    Inherits Common.LayoutAwarePage

        ''' <summary>
        ''' Populates the page with content passed during navigation.  Any saved state is also
        ''' provided when recreating a page from a prior session.
        ''' </summary>
        ''' <param name="navigationParameter">The parameter value passed to
        ''' <see cref="Frame.Navigate"/> when this page was initially requested.
        ''' </param>
        ''' <param name="pageState">A dictionary of state preserved by this page during an earlier
        ''' session.  This will be null the first time a page is visited.</param>
        Protected Overrides Sub LoadState(navigationParameter As Object, pageState As Dictionary(Of String, Object))
        End Sub

        ''' <summary>
        ''' Preserves state associated with this page in case the application is suspended or the
        ''' page is discarded from the navigation cache.  Values must conform to the serialization
        ''' requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        ''' </summary>
        ''' <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        Protected Overrides Sub SaveState(pageState As Dictionary(Of String, Object))

        End Sub

    Private Sub OnLoad(sender As Object, e As RoutedEventArgs) Handles RootPage.Loaded
        'Dim source As New System.Uri("http://www.google.lk/finance/chart?hl=en&tbo=d&q=CURRENCY:USDLKR&tkr=1&p=1Y&chst=vkc&chs=1260x400")
        'webview.Navigate(source)
        Try
            Dim profile = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile.NetworkAdapter
        Catch ex As Exception
            ErrorMsg("APP NEEDS INTERNET CONNECTIVITY, PLEASE CONNECT TO INTERNET")
        End Try
        fromCurrencyListCombo.SelectedIndex = 42
        toCurrencyListCombo.SelectedIndex = 84
    End Sub

    Private Sub DropDownOpened(sender As Object, e As Object) Handles fromCurrencyListCombo.DropDownOpened, toCurrencyListCombo.DropDownOpened
        webview.Visibility = Windows.UI.Xaml.Visibility.Collapsed
    End Sub

    Private Sub DropDownClosed(sender As Object, e As Object) Handles toCurrencyListCombo.DropDownClosed, fromCurrencyListCombo.DropDownClosed
        webview.Visibility = Windows.UI.Xaml.Visibility.Visible
    End Sub

    Private Function getCurrencyCode(ByVal selectedIndex As Integer) As String
        Dim str As String = "USD"
        selectedIndex += 1
        Select Case selectedIndex
            Case 1
                str = "AED"
            Case 2
                str = "ANG"
            Case 3
                str = "ARS"
            Case 4
                str = "AUD"
            Case 5
                str = "BDT"
            Case 6
                str = "BGN"
            Case 7
                str = "BHD"
            Case 8
                str = "BND"
            Case 9
                str = "BOB"
            Case 10
                str = "BRL"
            Case 11
                str = "BWP"
            Case 12
                str = "CAD"
            Case 13
                str = "CHF"
            Case 14
                str = "CLP"
            Case 15
                str = "CNY"
            Case 16
                str = "COP"
            Case 17
                str = "CRC"
            Case 18
                str = "CZK"
            Case 19
                str = "DKK"
            Case 20
                str = "DOP"
            Case 21
                str = "DZD"
            Case 22
                str = "EEK"
            Case 23
                str = "EGP"
            Case 24
                str = "EUR"
            Case 25
                str = "FJD"
            Case 26
                str = "GBP"
            Case 27
                str = "HKD"
            Case 28
                str = "HNL"
            Case 29
                str = "HRK"
            Case 30
                str = "HUF"
            Case 31
                str = "IDR"
            Case 32
                str = "ILS"
            Case 33
                str = "INR"
            Case 34
                str = "JMD"
            Case 35
                str = "JOD"
            Case 36
                str = "JPY"
            Case 37
                str = "KES"
            Case 38
                str = "KRW"
            Case 39
                str = "KWD"
            Case 40
                str = "KYD"
            Case 41
                str = "KZT"
            Case 42
                str = "LPB"
            Case 43
                str = "LKR"
            Case 44
                str = "LTL"
            Case 45
                str = "LVL"
            Case 46
                str = "MAD"
            Case 47
                str = "MDL"
            Case 48
                str = "MKD"
            Case 49
                str = "MUR"
            Case 50
                str = "MVR"
            Case 51
                str = "MXN"
            Case 52
                str = "MYR"
            Case 53
                str = "NAD"
            Case 54
                str = "NGN"
            Case 55
                str = "NIO"
            Case 56
                str = "NOK"
            Case 57
                str = "NPR"
            Case 58
                str = "NZD"
            Case 59
                str = "OMR"
            Case 60
                str = "PEN"
            Case 61
                str = "PGK"
            Case 62
                str = "PHP"
            Case 63
                str = "PKR"
            Case 64
                str = "PLN"
            Case 65
                str = "PYG"
            Case 66
                str = "QAR"
            Case 67
                str = "RON"
            Case 68
                str = "RSD"
            Case 69
                str = "RUB"
            Case 70
                str = "SAR"
            Case 71
                str = "SCR"
            Case 72
                str = "SEK"
            Case 73
                str = "SGD"
            Case 74
                str = "SKK"
            Case 75
                str = "SLL"
            Case 76
                str = "SVS"
            Case 77
                str = "THB"
            Case 78
                str = "TND"
            Case 79
                str = "TRY"
            Case 80
                str = "TTD"
            Case 81
                str = "TWD"
            Case 82
                str = "TZS"
            Case 83
                str = "UAH"
            Case 84
                str = "UGX"
            Case 85
                str = "USD"
            Case 86
                str = "UYU"
            Case 87
                str = "UZS"
            Case 88
                str = "VEF"
            Case 89
                str = "VND"
            Case 90
                str = "XOF"
            Case 91
                str = "YER"
            Case 92
                str = "ZAR"
            Case 93
                str = "ZMK"
            Case Else
                str = "USD"
        End Select
        Return str
    End Function

    Private Async Sub btnConvert_Click(sender As Object, e As RoutedEventArgs) Handles btnConvert.Click
        progressRingGoButton.IsActive = True
        Dim webclient As New Net.Http.HttpClient
        Dim value As String
        Dim fromCurrency As String
        Dim toCurrency As String
        Dim webviewHeight As String = webview.ActualHeight.ToString
        Dim webviewWidth As String = webview.ActualWidth.ToString
        If lhsTextBox.Text = "" And rhsTextBox.Text = "" Then
            ErrorMsg("Enter a valid number in one of the two text boxes, left side OR right side")
        ElseIf lhsTextBox.Text.Length <> 0 And rhsTextBox.Text.Length <> 0 Then
            lhsTextBox.Text = ""
            rhsTextBox.Text = ""
            ErrorMsg("Enter a valid number in one of the two text boxes, left side OR right side not the both")
        ElseIf lhsTextBox.Text.Length = 0 And rhsTextBox.Text.Length <> 0 Then
            Try
                value = Double.Parse(rhsTextBox.Text)
            Catch ex As Exception
                rhsTextBox.Text = "0"
                ErrorMsg("Enter a valid number")
            End Try
            fromCurrency = getCurrencyCode(toCurrencyListCombo.SelectedIndex)
            toCurrency = getCurrencyCode(fromCurrencyListCombo.SelectedIndex)
            Dim webUriString As String = "http://www.google.com/ig/calculator?hl=en&q=" + value + fromCurrency + "=?" + toCurrency

            txtGraphName.Text = "Last one year change of " + getCurrencyCode(toCurrencyListCombo.SelectedIndex) + " per 1 " + getCurrencyCode(fromCurrencyListCombo.SelectedIndex)

            Dim webviewstring As String
            webviewstring = "http://www.google.lk/finance/chart?hl=en&tbo=d&q=CURRENCY:" + fromCurrency + toCurrency + "&tkr=1&p=1Y&chst=vkc&chs=" + webviewWidth + "x" + webviewHeight
            Dim source As New System.Uri(webviewstring)
            webview.Navigate(source)

            Dim result As String = Await webclient.GetStringAsync(webUriString)
            Dim resultArray() As String = result.Split(",")
            result = resultArray(1)
            result = result.Substring(6)
            result = result.Substring(0, result.Length - 1)
            lhsTextBox.Text = result

        ElseIf lhsTextBox.Text.Length <> 0 And rhsTextBox.Text.Length = 0 Then
            Try
                value = Double.Parse(lhsTextBox.Text)
            Catch ex As Exception
                rhsTextBox.Text = "0"
                ErrorMsg("Enter a valid number")
            End Try
            fromCurrency = getCurrencyCode(fromCurrencyListCombo.SelectedIndex)
            toCurrency = getCurrencyCode(toCurrencyListCombo.SelectedIndex)
            Dim webUriString As String = "http://www.google.com/ig/calculator?hl=en&q=" + value + fromCurrency + "=?" + toCurrency

            txtGraphName.Text = "Last one year change of " + getCurrencyCode(fromCurrencyListCombo.SelectedIndex) + " per 1 " + getCurrencyCode(toCurrencyListCombo.SelectedIndex)

            Dim webviewstring As String
            
            webviewstring = "http://www.google.lk/finance/chart?hl=en&tbo=d&q=CURRENCY:" + fromCurrency + toCurrency + "&tkr=1&p=1Y&chst=vkc&chs=1250x400"
            Dim source As New System.Uri(webviewstring)
            webview.Navigate(source)



            Dim result As String = Await webclient.GetStringAsync(webUriString)
            Dim resultArray() As String = result.Split(",")
            result = resultArray(1)
            result = result.Substring(6)
            result = result.Substring(0, result.Length - 1)
            rhsTextBox.Text = result
        End If
        'Dim webUriString As String = "http://www.google.com/ig/calculator?hl=en&q=1.25GBP=?USD"
        'Dim result As String = Await webclient.GetStringAsync(webUriString)
        'Dim resultArray() As String = result.Split(",")
        'result = resultArray(1)
        'result = result.Substring(6)
        'result = result.Substring(0, 6)
        'lhsTextBox.Text = result

        progressRingGoButton.IsActive = False
    End Sub

    Private Sub onWebviewLoaded(sender As Object, e As RoutedEventArgs)
        webview.Visibility = Windows.UI.Xaml.Visibility.Collapsed
        progressRingWebView.IsActive = True
    End Sub

    Private Sub onWebviewLoadComplete(sender As Object, e As Navigation.NavigationEventArgs) Handles webview.LoadCompleted
        progressRingWebView.IsActive = False
        webview.Visibility = Windows.UI.Xaml.Visibility.Visible
    End Sub

    Protected Async Sub ErrorMsg(ByVal message)
        Dim msgDlg As New Windows.UI.Popups.MessageDialog(message)
        msgDlg.DefaultCommandIndex = 0
        Await msgDlg.ShowAsync
    End Sub


    Private Sub textChangedRhs(sender As Object, e As TextChangedEventArgs) Handles rhsTextBox.TextChanged
        If rhsTextBox.Text.Length <= 1 Then
            lhsTextBox.Text = ""
        End If
    End Sub

    Private Sub textChangedLhs(sender As Object, e As TextChangedEventArgs) Handles lhsTextBox.TextChanged
        If lhsTextBox.Text.Length <= 1 Then
            rhsTextBox.Text = ""
        End If

    End Sub

    Private Sub webViewSizeChanged(sender As Object, e As SizeChangedEventArgs) Handles webview.SizeChanged
        Dim webviewHeight As String = webview.ActualWidth.ToString
        Dim webviewWidth As String = webview.ActualHeight.ToString
        Dim fromCurrency As String
        Dim toCurrency As String
        Dim webviewstring As String
        fromCurrency = getCurrencyCode(toCurrencyListCombo.SelectedIndex)
        toCurrency = getCurrencyCode(fromCurrencyListCombo.SelectedIndex)
        webviewstring = "http://www.google.lk/finance/chart?hl=en&tbo=d&q=CURRENCY:" + fromCurrency + toCurrency + "&tkr=1&p=1Y&chst=vkc&chs=1250x400"
        Dim source As New System.Uri(webviewstring)
        webview.Navigate(source)
    End Sub

    Private Sub webview_LayoutUpdated(sender As Object, e As Object) Handles webview.LayoutUpdated
        'Dim webviewHeight As String = webview.MinHeight
        'Dim webviewWidth As String = webview.MinWidth
        'Dim fromCurrency As String
        'Dim toCurrency As String
        'Dim webviewstring As String
        'fromCurrency = getCurrencyCode(toCurrencyListCombo.SelectedIndex)
        'toCurrency = getCurrencyCode(fromCurrencyListCombo.SelectedIndex)
        'webviewstring = "http://www.google.lk/finance/chart?hl=en&tbo=d&q=CURRENCY:" + fromCurrency + toCurrency + "&tkr=1&p=1Y&chst=vkc&chs=1250x400"
        'Dim source As New System.Uri(webviewstring)
        'webview.Navigate(source)
    End Sub

    Private Sub RootPage_SizeChanged(sender As Object, e As SizeChangedEventArgs) Handles RootPage.SizeChanged
        'Dim webviewHeight As String = webview.ActualHeight.ToString
        'Dim webviewWidth As String = webview.ActualWidth.ToString
        'Dim fromCurrency As String
        'Dim toCurrency As String
        'Dim webviewstring As String
        'fromCurrency = getCurrencyCode(toCurrencyListCombo.SelectedIndex)
        'toCurrency = getCurrencyCode(fromCurrencyListCombo.SelectedIndex)
        'webviewstring = "http://www.google.lk/finance/chart?hl=en&tbo=d&q=CURRENCY:" + fromCurrency + toCurrency + "&tkr=1&p=1Y&chst=vkc&chs=1250x400"
        'Dim source As New System.Uri(webviewstring)
        'webview.Navigate(source)
    End Sub
End Class
