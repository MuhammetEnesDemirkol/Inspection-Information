-- CREATE TABLE hastaBilgileri (
--   tc_kimlik_numarasi VARCHAR(11) PRIMARY KEY,
--   isim VARCHAR(255) NOT NULL,
--   soyisim VARCHAR(255) NOT NULL,
--   dogum_yeri VARCHAR(255) NOT NULL,
--   dogum_tarihi DATE NOT NULL,
--   medeni_durumu VARCHAR(255) NOT NULL,
--   telefon_numarasi VARCHAR(255) NOT NULL
-- );
-- ALTER TABLE hastaBilgileri
--   ALTER COLUMN dogum_tarihi TYPE varchar(255) USING to_char(dogum_tarihi, 'DD-MM-YYYY');
-- ALTER TABLE hastaBilgileri
--   ADD COLUMN cinsiyet VARCHAR(255);

-- CREATE TABLE muayeneBilgileri (
--   tc_kimliknumarasi VARCHAR(11) PRIMARY KEY,
--   muayene_tarihi DATE NOT NULL,
--   hasta_sikayeti VARCHAR(255) NOT NULL,
--   doktor_yorumu VARCHAR(255) NOT NULL,
--   recete_numarasi NUMERIC
-- );

-- ALTER TABLE muayenebilgileri
-- ALTER COLUMN recete_numarasi SET DEFAULT 0;

-- CREATE TABLE ilaclar (
--   barkod_numarasi VARCHAR(255) PRIMARY KEY,
--   ilac_adi VARCHAR(255) NOT NULL,
--   ilac_tipi VARCHAR(255) NOT NULL
-- );

-- ALTER TABLE muayenebilgileri
-- ALTER COLUMN recete_numarasi SET DEFAULT 0;

--   ALTER  TABLE muayenebilgileri
--   ALTER COLUMN muayene_tarihi TYPE varchar(255) USING to_char(muayene_tarihi, 'YYYY-MM-DD');

-- CREATE TABLE receteler (
-- 	tckimlik_numarasi VARCHAR(11) PRIMARY KEY,
-- 	recete_tarihi DATE NOT NULL,
-- 	ilac_barkod_numarasi VARCHAR(255) NOT NULL,
-- 	kutu_adeti VARCHAR(5) NOT NULL,
-- 	recete_numarasi VARCHAR(255) NOT NULL
-- 	);
--  ALTER  TABLE receteler
--  ALTER COLUMN recete_tarihi TYPE varchar(255) USING to_char(recete_tarihi, 'YYYY-MM-DD');

-- ALTER TABLE receteler DROP CONSTRAINT receteler_pkey
-- ALTER TABLE muayenebilgileri DROP CONSTRAINT muayenebilgileri_pkey
-- ALTER TABLE hastabilgileri DROP CONSTRAINT hastabilgileri_pkey