// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ICommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Defines the command behavior of an interactive UI element that performs an action when invoked, such as sending an email, deleting an item, or submitting a form.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3853464898, 51815, 16513, 153, 91, 112, 157, 209, 55, 146, 223)]
  public interface ICommand
  {
    /// <summary>Occurs whenever something happens that affects whether the command can execute.</summary>
    event EventHandler<object> CanExecuteChanged;

    /// <summary>Retrieves whether the command can execute in its current state.</summary>
    /// <param name="parameter">Data used by the command. If the command does not require data, this object can be set to null.</param>
    /// <returns>**true** if this command can be executed; otherwise, **false**.</returns>
    bool CanExecute(object parameter);

    /// <summary>Defines the method to be called when the command is invoked.</summary>
    /// <param name="parameter">Data used by the command. If the command does not require data to be passed, this value can be null.</param>
    void Execute(object parameter);
  }
}
