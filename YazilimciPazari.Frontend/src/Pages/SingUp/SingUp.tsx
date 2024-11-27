import React, { useState } from 'react';
import { Formik, Form, Field, ErrorMessage } from 'formik';
import * as Yup from 'yup';

export default function SignUp() {
  const [userType, setUserType] = useState('individual'); // 'individual' veya 'company'

  // Doğrulama şemalarını tanımla
  const individualValidationSchema = Yup.object({
    name: Yup.string().required('İsim zorunludur'),
    tcNo: Yup.string()
      .length(11, 'TC Kimlik No 11 haneli olmalıdır')
      .required('TC Kimlik No zorunludur'),
    email: Yup.string()
      .email('Geçerli bir e-posta adresi girin')
      .required('E-posta zorunludur'),
    password: Yup.string()
      .min(6, 'Şifre en az 6 karakter olmalıdır')
      .required('Şifre zorunludur'),
  });

  const companyValidationSchema = Yup.object({
    companyName: Yup.string().required('Şirket adı zorunludur'),
    taxNo: Yup.string()
      .min(10, 'Vergi No en az 10 haneli olmalıdır')
      .required('Vergi No zorunludur'),
    email: Yup.string()
      .email('Geçerli bir e-posta adresi girin')
      .required('E-posta zorunludur'),
    password: Yup.string()
      .min(6, 'Şifre en az 6 karakter olmalıdır')
      .required('Şifre zorunludur'),
  });

  const initialValues =
    userType === 'individual'
      ? {
          name: '',
          tcNo: '',
          email: '',
          password: '',
        }
      : {
          companyName: '',
          taxNo: '',
          email: '',
          password: '',
        };

  const validationSchema =
    userType === 'individual'
      ? individualValidationSchema
      : companyValidationSchema;

  return (
    <div className='container mt-5'>
      <div className='row justify-content-center'>
        <div className='col-md-6'>
          <h2 className='text-center mb-4'>Kayıt Ol</h2>
          <div className='d-flex justify-content-center mb-4'>
            <button
              className={`btn ${
                userType === 'individual' ? 'btn-primary' : 'btn-outline-primary'
              } me-2`}
              onClick={() => setUserType('individual')}
            >
              Kişi
            </button>
            <button
              className={`btn ${
                userType === 'company' ? 'btn-primary' : 'btn-outline-primary'
              }`}
              onClick={() => setUserType('company')}
            >
              Şirket
            </button>
          </div>
          <Formik
            initialValues={initialValues}
            validationSchema={validationSchema}
            onSubmit={(values) => {
              console.log(values);
              // api işlemleri
            }}
          >
            {() => (
              <Form>
                {userType === 'individual' && (
                  <>
                    <div className='form-group mb-3'>
                      <label htmlFor='name'>İsim</label>
                      <Field
                        name='name'
                        type='text'
                        className='form-control'
                      />
                      <ErrorMessage
                        name='name'
                        component='div'
                        className='text-danger'
                      />
                    </div>
                    <div className='form-group mb-3'>
                      <label htmlFor='tcNo'>TC Kimlik No</label>
                      <Field
                        name='tcNo'
                        type='text'
                        className='form-control'
                      />
                      <ErrorMessage
                        name='tcNo'
                        component='div'
                        className='text-danger'
                      />
                    </div>
                  </>
                )}

                {userType === 'company' && (
                  <>
                    <div className='form-group mb-3'>
                      <label htmlFor='companyName'>Şirket Adı</label>
                      <Field
                        name='companyName'
                        type='text'
                        className='form-control'
                      />
                      <ErrorMessage
                        name='companyName'
                        component='div'
                        className='text-danger'
                      />
                    </div>
                    <div className='form-group mb-3'>
                      <label htmlFor='taxNo'>Vergi No</label>
                      <Field
                        name='taxNo'
                        type='text'
                        className='form-control'
                      />
                      <ErrorMessage
                        name='taxNo'
                        component='div'
                        className='text-danger'
                      />
                    </div>
                  </>
                )}

                {/* Ortak Alanlar */}
                <div className='form-group mb-3'>
                  <label htmlFor='email'>E-posta</label>
                  <Field
                    name='email'
                    type='email'
                    className='form-control'
                  />
                  <ErrorMessage
                    name='email'
                    component='div'
                    className='text-danger'
                  />
                </div>
                <div className='form-group mb-3'>
                  <label htmlFor='password'>Şifre</label>
                  <Field
                    name='password'
                    type='password'
                    className='form-control'
                  />
                  <ErrorMessage
                    name='password'
                    component='div'
                    className='text-danger'
                  />
                </div>

                <button className='btn btn-success w-100' type='submit'>
                  Kayıt Ol
                </button>
              </Form>
            )}
          </Formik>
        </div>
      </div>
    </div>
  );
}
