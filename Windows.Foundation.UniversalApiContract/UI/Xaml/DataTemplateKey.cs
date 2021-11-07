// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DataTemplateKey
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the resource key for the DataTemplate class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IDataTemplateKeyFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class DataTemplateKey : IDataTemplateKey
  {
    /// <summary>Initializes a new instance of the DataTemplateKey class.</summary>
    [MethodImpl]
    public extern DataTemplateKey();

    /// <summary>Initializes a new instance of the DataTemplateKey class with the specified type.</summary>
    /// <param name="dataType">The type for which this template is designed. </param>
    [MethodImpl]
    public extern DataTemplateKey(object dataType);

    /// <summary>Gets or sets the type for which the template is designed.</summary>
    /// <returns>The type of object that the template is used to display, or a string that specifies the XML tag name for the XML data that the template is used to display.</returns>
    public extern object DataType { [MethodImpl] get; [MethodImpl] set; }
  }
}
