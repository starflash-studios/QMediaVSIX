// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.GeneratorPositionHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides utility methods for evaluating and creating GeneratorPosition structure values. C# and Microsoft Visual Basic code should use members of GeneratorPosition instead.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGeneratorPositionHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class GeneratorPositionHelper : IGeneratorPositionHelper
  {
    /// <summary>Creates a GeneratorPosition value using provided values for index and offset. C# and Microsoft Visual Basic code should use GeneratorPosition(Int32,Int32) instead.</summary>
    /// <param name="index">The index value to create with.</param>
    /// <param name="offset">The offset value to create with.</param>
    /// <returns>The created GeneratorPosition structure with the desired values.</returns>
    [MethodImpl]
    public static extern GeneratorPosition FromIndexAndOffset(
      int index,
      int offset);
  }
}
