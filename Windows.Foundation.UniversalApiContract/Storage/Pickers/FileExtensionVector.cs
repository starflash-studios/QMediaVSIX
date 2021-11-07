// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FileExtensionVector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  /// <summary>Represents a random-access collection of file name extensions.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FileExtensionVector : IVector<string>, IIterable<string>
  {
    [MethodImpl]
    public extern string GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<string> GetView();

    [MethodImpl]
    public extern bool IndexOf(string value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, string value);

    [MethodImpl]
    public extern void InsertAt(uint index, string value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(string value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] string[] items);

    [MethodImpl]
    public extern void ReplaceAll(string[] items);

    [MethodImpl]
    public extern IIterator<string> First();
  }
}
