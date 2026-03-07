#!/usr/bin/env python3
"""
VB.NET Encoding Helper
======================
Tüm .vb dosyaları için STANDART ENCODING: UTF-8-SIG (UTF-8 with BOM)

Bu script:
1. .vb dosyalarını okur
2. UTF-8-SIG encoding kullanır
3. Türkçe karakterleri korur
"""

import codecs

STANDARD_ENCODING = 'utf-8-sig'

def read_vb_file(filepath):
    """VB dosyasını doğru encoding ile oku"""
    try:
        with codecs.open(filepath, 'r', encoding=STANDARD_ENCODING) as f:
            return f.read()
    except Exception as e:
        # Fallback: farklı encoding'lerle dene
        for enc in ['utf-8', 'utf-16', 'iso-8859-9', 'windows-1254']:
            try:
                with open(filepath, 'r', encoding=enc) as f:
                    return f.read()
            except:
                continue
        raise Exception(f"Dosya okunamadı: {e}")

def write_vb_file(filepath, content):
    """VB dosyasını UTF-8-SIG ile yaz"""
    with codecs.open(filepath, 'w', encoding=STANDARD_ENCODING) as f:
        f.write(content)

# Örnek kullanım:
if __name__ == "__main__":
    import sys
    
    if len(sys.argv) < 2:
        print("Kullanım: python vb_encoding_helper.py <dosya.vb>")
        sys.exit(1)
    
    filepath = sys.argv[1]
    
    try:
        content = read_vb_file(filepath)
        print(f"✅ Dosya okundu: {len(content)} karakter")
        print(f"Encoding: {STANDARD_ENCODING}")
        
        # Tekrar yaz (encoding'i düzelt)
        write_vb_file(filepath, content)
        print(f"✅ Dosya kaydedildi: {filepath}")
        
    except Exception as e:
        print(f"❌ Hata: {e}")
        sys.exit(1)
