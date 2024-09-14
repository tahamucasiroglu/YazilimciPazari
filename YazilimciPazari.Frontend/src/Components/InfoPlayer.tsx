import { Dialog, DialogTitle, Typography } from '@mui/material';
import { useEffect, useRef } from 'react'

export interface SimpleDialogProps {
  open: boolean;
  setOpen: React.Dispatch<React.SetStateAction<boolean>>;
}

export default function InfoPlayer(props: SimpleDialogProps) {
  const audioRef = useRef(new Audio('/İnfoSound.mp3'));
  const { open, setOpen } = props;

  useEffect(() => {
    if (open) {
      audioRef.current.play();
    } else {
      audioRef.current.pause();
      audioRef.current.currentTime = 0;
    }
  }, [open]);

  const closingEvent = () => {
    setOpen(false);
  }

  
  return (
    <Dialog open={open} onClose={closingEvent}>
      <DialogTitle>
      <Typography className='p-2 fs-4 text-center'>Sitemizin Amacı</Typography>
      </DialogTitle>
      <Typography variant='body1' className='p-3'>
        Dünya değişiyor. Değişen dünyada hayatta kalmanın en önemli yolu teknolojiyi kullanabilmek. Mesela dinlediğiniz bu ses gerçek değil. Bazılarınız anladı bazılarınız anlamadı.  Asıl konumuza gelecek olursak...
        <br/><br/>
        Korona salgını öncesi insanlar yazılım geliştiricilerine zor olarak bakmaktaydı. Korona zamanı herkes yazılım öğrenmeye çalıştı ve bazıları başarılı oldu. Devamında daha çok insan denedi ve öncesine göre daha çok insan başarılı oldu. Artık herkes yazılım üretmek için yıllarca okul okumanın gereksiz olduğunu bir kaç video ile bunun başarılacağını anladı. Anladılar fakat dediklerim sizce doğru mu?
        <br/><br/>
        Bu yüzden bu siteyi açtım. Herkes yazılımcı olabilir fakat herkes yazılım üretemez. Algoritma, veri bilimi, kod düzenlemesi, dil seçimi, bellek yönetimi ve bir çok şeyi internetten öğrenebilirsiniz fakat bunu o videolarda göremezsiniz. 
        <br/><br/>
        Şirketler ise herkesi, ekonominin verdiği etkiyi de göz ardı etmeyelim, işe almaya başladılar. Sonunda yazılım geliştirici enflasyonu oluştu. Programlama dili ile "Hello World" yazan adam CV'sine o dilde usta olduğunu yazmakta. 
        <br/><br/>
        Sistem tamamen bozulduğu için düzen tamamen rastgele şekilde ilerliyor. Burada sizler gidip şirketlere başvurmayacaksınız. Şirketler size başvuru gönderecek. Burada asıl olay, her şeyi olabildiğince sade yapmak. Farkımız ise güvenimizden gelecek. Girişte bir sözleşme var. O sözleşmede kabul ettiğiniz temel şeyler;
        <br/>1-) bilgilerinizin doğru olması aksi halde siteden atılmanız. Burada şirketler ile iletişimde olacağız.
        <br/>2-) kara liste sayfamız var. Sahtekarlar ortada sergilenecek. Hatasını anlayanlar oradan kalkmak isterler ise bir şirketin insan kaynaklarından referans ve 1000 adet fidan dikildiğine dair belge vermeleri gerekecek. 
        <br/><br/>
        Burada yaptıklarımız başta kişileri kendine çekmeyecek fakat ileride bir gün herkes bu saçmalıktan bıkacak ve o zaman burayı kullanacaklar. O aradığınız gelişim, güven ve köle olmadan çalışma hayatını iki taraflı olarak korumaktayız. Sadece yazılımcılar değil şirketlerde kara listeye düşebilir ve onlar için telafisi daha ağır olacak. 
        <br/><br/>
        Şuan için hedeflerimiz bunlar. İş görüşmelerinde iki taraf kabul ederse herkese açık olması gibi bazı düşüncelerimiz var. Şuan ise tek hedefimiz güvendir. Dinlediğiniz için teşekkürler
      </Typography>
    
    </Dialog>
  )
}
