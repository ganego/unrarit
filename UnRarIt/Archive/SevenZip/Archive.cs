﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using UnRarIt.Interop;

namespace UnRarIt.Archive.SevenZip
{
    internal class SevenZipArchive : IDisposable, IInArchive
    {
        [DllImport("7z_Win32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "CreateObject")]
        private extern static int CreateObject_32(ref Guid classID, ref Guid interfaceID, [MarshalAs(UnmanagedType.Interface)] out object outObject);

        [DllImport("7z_x64.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "CreateObject")]
        private extern static int CreateObject_64(ref Guid classID, ref Guid interfaceID, [MarshalAs(UnmanagedType.Interface)] out object outObject);


        private static Guid FormatSevenZip = new Guid("23170f69-40c1-278a-1000-000110070000");

        private IInArchive inArchive = null;
        private SevenZipStream stream;
        internal SevenZipArchive(FileInfo aFile, IArchiveOpenCallback callback)
        {
            Guid Interface = typeof(IInArchive).GUID;
            object result;
            if (CpuInfo.isX64)
            {
                CreateObject_64(ref FormatSevenZip, ref Interface, out result);
            }
            else
            {
                CreateObject_32(ref FormatSevenZip, ref Interface, out result);
            }
            if (result == null)
            {
                throw new COMException("Cannot create InArchive");
            }
            inArchive = result as IInArchive;

            stream = new SevenZipFileStream(aFile, FileMode.Open, FileAccess.Read);
            ulong sp = 4194304;
            inArchive.Open(stream, ref sp, callback);

        }
        public void Dispose()
        {
            Close();
        }

        public void Open(IInStream stream, ref ulong maxCheckStartPosition, IArchiveOpenCallback openArchiveCallback)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            if (inArchive != null)
            {
                inArchive.Close();
                inArchive = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        public uint GetNumberOfItems()
        {
            return inArchive.GetNumberOfItems();
        }

        public void GetProperty(uint index, ItemPropId propID, ref PropVariant value)
        {
            inArchive.GetProperty(index, propID, ref value);
        }

        public Variant GetProperty(uint Index, ItemPropId propId)
        {
            return new Variant(this, Index, propId);
        }

        public void Extract(uint[] indices, uint numItems, ExtractMode testMode, IArchiveExtractCallback extractCallback)
        {
            inArchive.Extract(indices, numItems, testMode, extractCallback);
        }

        public void GetArchiveProperty(ItemPropId propID, ref PropVariant value)
        {
            inArchive.GetArchiveProperty(propID, ref value);
        }

        public Variant GetArchiveProperty(ItemPropId propId)
        {
            return new Variant(this, propId);
        }

        public uint GetNumberOfProperties()
        {
            return inArchive.GetNumberOfProperties();
        }

        public void GetPropertyInfo(uint index, out string name, out ItemPropId propID, out ushort varType)
        {
            inArchive.GetPropertyInfo(index, out name, out propID, out varType);
        }

        public uint GetNumberOfArchiveProperties()
        {
            return inArchive.GetNumberOfArchiveProperties();
        }

        public void GetArchivePropertyInfo(uint index, string name, out ItemPropId propID, out ushort varType)
        {
            inArchive.GetArchivePropertyInfo(index, name, out propID, out varType);
        }

        public ISequentialInStream GetStream(uint index)
        {
            return (inArchive as IInArchiveGetStream).GetStream(index);
        }
    }
}
