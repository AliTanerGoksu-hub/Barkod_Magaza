-- Google API Key'lerini tbParamGenel tablosuna kaydet
-- API Key: AIzaSyC_dOGn3xgVmBgkJv4b6_03StemDSbrWIg
-- Search Engine ID: d3830d60b868641c4

-- Eğer kayıt varsa güncelle
UPDATE tbParamGenel 
SET sGoogleSearchApiKey = 'AIzaSyC_dOGn3xgVmBgkJv4b6_03StemDSbrWIg',
    sGoogleSearchEngineId = 'd3830d60b868641c4'
WHERE nParamID = 1;

-- Eğer kayıt yoksa ekle
IF @@ROWCOUNT = 0
BEGIN
    INSERT INTO tbParamGenel (nParamID, sGoogleSearchApiKey, sGoogleSearchEngineId, bAIKullan)
    VALUES (1, 'AIzaSyC_dOGn3xgVmBgkJv4b6_03StemDSbrWIg', 'd3830d60b868641c4', 1);
END

-- Kontrol
SELECT nParamID, sGoogleSearchApiKey, sGoogleSearchEngineId, bAIKullan 
FROM tbParamGenel 
WHERE nParamID = 1;

PRINT 'Google API key''leri başarıyla kaydedildi!';
