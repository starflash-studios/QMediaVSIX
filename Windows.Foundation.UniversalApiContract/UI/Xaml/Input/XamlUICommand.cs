// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.XamlUICommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides a base class for defining the command behavior of an interactive UI element that performs an action when invoked (such as sending an email, deleting an item, or submitting a form).</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IXamlUICommandStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Composable(typeof (IXamlUICommandFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  public class XamlUICommand : DependencyObject, IXamlUICommand, ICommand
  {
    /// <summary>Initializes a new instance of the XamlUICommand class.</summary>
    [MethodImpl]
    public extern XamlUICommand();

    /// <summary>Gets or sets the label for this element.</summary>
    /// <returns>The label for this element.</returns>
    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a glyph from the Segoe MDL2 Assets font for this element.</summary>
    /// <returns>A glyph from the Segoe MDL2 Assets font for this element.</returns>
    public extern IconSource IconSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of key combinations for this element that invoke an action using the keyboard.</summary>
    /// <returns>The keyboard accelerators for this element.</returns>
    public extern IVector<KeyboardAccelerator> KeyboardAccelerators { [MethodImpl] get; }

    /// <summary>Gets or sets the access key (mnemonic) for this element.</summary>
    /// <returns>The access key (mnemonic) for this element.</returns>
    public extern string AccessKey { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a description for this element.</summary>
    /// <returns>The description for this element.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the command behavior of an interactive UI element that performs an action when invoked, such as sending an email, deleting an item, or submitting a form.</summary>
    /// <returns>The command behavior of the element.</returns>
    public extern ICommand Command { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when an Execute call is made.</summary>
    public extern event TypedEventHandler<XamlUICommand, ExecuteRequestedEventArgs> ExecuteRequested;

    /// <summary>Occurs when a CanExecute call is made.</summary>
    public extern event TypedEventHandler<XamlUICommand, CanExecuteRequestedEventArgs> CanExecuteRequested;

    /// <summary>Notifies the system that the command state has changed.</summary>
    [MethodImpl]
    public extern void NotifyCanExecuteChanged();

    public extern event EventHandler<object> CanExecuteChanged;

    [MethodImpl]
    public extern bool CanExecute(object parameter);

    [MethodImpl]
    public extern void Execute(object parameter);

    /// <summary>Identifies the Label dependency property.</summary>
    /// <returns>The identifier for the Label dependency property.</returns>
    public static extern DependencyProperty LabelProperty { [MethodImpl] get; }

    /// <summary>Identifies the IconSource dependency property.</summary>
    /// <returns>The identifier for the IconSource dependency property.</returns>
    public static extern DependencyProperty IconSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the KeyboardAccelerators dependency property.</summary>
    /// <returns>The identifier for the KeyboardAccelerators dependency property.</returns>
    public static extern DependencyProperty KeyboardAcceleratorsProperty { [MethodImpl] get; }

    /// <summary>Identifies the AccessKey dependency property.</summary>
    /// <returns>The identifier for the AccessKey dependency property.</returns>
    public static extern DependencyProperty AccessKeyProperty { [MethodImpl] get; }

    /// <summary>Identifies the Description dependency property.</summary>
    /// <returns>The identifier for the Description dependency property.</returns>
    public static extern DependencyProperty DescriptionProperty { [MethodImpl] get; }

    /// <summary>Identifies the Command dependency property.</summary>
    /// <returns>The identifier for the Command dependency property.</returns>
    public static extern DependencyProperty CommandProperty { [MethodImpl] get; }
  }
}
